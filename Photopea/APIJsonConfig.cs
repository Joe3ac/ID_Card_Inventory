using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace ID_Card_Inventory.Photopea
{
   public class PhotopeaConfig
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["InventoryDB"].ConnectionString;
        //private string _connectionString;

        //public PhotopeaConfig(string connectionString)
        //{
        //    _connectionString = connectionString;
        //}
        private static int _setID;
        public static void SetSelectedID (int id)
        {
            _setID = id;

        }
        public static int GetSelectedID()
        {
            return _setID;
        }
        public static byte[] LoadImage(int IDNum)
        {
            try
            {
                using (SqlConnection _connectSQL = new SqlConnection(_connectionString))
                {
                    _connectSQL.Open();
                    //try
                    //{
                        using (SqlCommand command = new SqlCommand("SelectIDPhoto", _connectSQL))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@IdNum", IDNum);
                            object result = command.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])result;
                                return imageBytes;
                            }
                            else
                            {
                                throw new Exception("No image found for the provided ID number.");
                            }
                         
                        }
                        
                    
                }




            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException invOpEx)
            {
                MessageBox.Show($"Invalid Operation: {invOpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;
        }

        public static async Task OpenInPhotopeaAsync(Microsoft.Web.WebView2.WinForms.WebView2 webView)
        {
            // Step 1: Get image from DB
            // Replace with actual DB fetch
           
             int photoId = GetSelectedID();
            byte[] imageBytes = LoadImage(photoId);

            // Step 2: Ensure image is in PNG format and save to temp file
            string tempPath = Path.Combine(Path.GetTempPath(), "photopea_input.png");
            //using (var ms = new MemoryStream(imageBytes))
            //{
            //    try
            //    {
            //        using (var img = System.Drawing.Image.FromStream(ms))
            //        {
            //            img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Png);
            //        }
            //    }
            //    catch (ArgumentException)
            //    {
            //        // If imageBytes is already a PNG or not a valid image, just write as is
            //        File.WriteAllBytes(tempPath, imageBytes);
            //    }
            //}

            using var ms = new MemoryStream(imageBytes);
            using var img = System.Drawing.Image.FromStream(ms);
            img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Png);


            // In real use: expose via localhost server or upload to a host
            string hostedUrl = $"https://localhost:7040/api/photopea/{Path.GetFileName(tempPath)}";


            // Step 3: Build JSON config
            var cfg = new
            {
                files = new[]
        {
            hostedUrl,
            "https://www.mysite.com/images/button.png",   // example
            "data:image/png;base64," + Convert.ToBase64String(imageBytes) // inline fallback
        },
        resources = new[]
        {
            "https://www.xyz.com/brushes/Nature.ABR",
            "https://www.xyz.com/grads/Gradients.GRD",
            "https://www.xyz.com/fonts/NewFont.otf"
        },
        server = new
        {
            version = 1,
            url = "https://www.myserver.com/saveImage.php",
            formats = new[] { "psd:true", "png", "jpg:0.5" }
        },
        environment = new
        {
            theme = "dark",
            lang = "en",
            uiScale = 1.0
        },
        apis = new
        {
            dezgo = "d4e5f6"
        },
        script = "app.activeDocument.rotateCanvas(90);" // Example script
            };
            string json = JsonSerializer.Serialize(cfg, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = false
            });
            string encoded = Uri.EscapeDataString(json);
            string url = $"https://www.photopea.com/#{encoded}";

            // Step 4: Load Photopea inside WebView2
            await webView.EnsureCoreWebView2Async();
            webView.CoreWebView2.Navigate(url);
        }
    }
}
