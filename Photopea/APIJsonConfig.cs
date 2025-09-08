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
            var SetImage = new PostResponse(); // Replace with actual DB fetch
            
            int photoId = SetImage.getIDNum;
           byte[] imageBytes = LoadImage(photoId);

            // Step 2: Save to temp file (for local testing we pretend it’s hosted)
            string tempPath = Path.Combine(Path.GetTempPath(), "photopea_input.png");
            File.WriteAllBytes(tempPath, imageBytes);

            // In real use: expose via localhost server or upload to a host
            string hostedUrl = "$\"https://localhost:7040/api/photopea/{photoId}";

            // Step 3: Build JSON config
            var cfg = new
            {
                files = new[] { hostedUrl },
                environment = new { theme = "dark" }
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
