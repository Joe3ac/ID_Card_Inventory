using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
usin


namespace ID_Card_Inventory.Photopea
{
   public class PhotopeaConfig
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["InventoryDB"].ConnectionString;

        private static byte[] LoadImage(int IDNum)
        { 

        }

        public static async Task OpenInPhotopeaAsync(Microsoft.Web.WebView2.WinForms.WebView2 webView)
        {
            // Step 1: Get image from DB
            var SetImage = new PostResponse(); // Replace with actual DB fetch
            
            int photoId = SetImage.getIDNum;

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
