using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ID_Card_Inventory.GithubUpdates
{
    public class UpdateChecker
    {
        private const string RepoOwner = "Joe3ac";
        private const string RepoName = "ID_Card_Inventory";
        private const string ApiUrl = $"https://api.github.com/repos/{RepoOwner}/{RepoName}/releases/latest";

        public static async Task<string?> GetLatestReleaseTagAsync()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("UpdateCheckerApp");

            var response = await client.GetAsync(ApiUrl);
            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(json);
            if (doc.RootElement.TryGetProperty("tag_name", out var tag))
                return tag.GetString();

            return null;
        }

        public static async Task Main(string[] args)
        {
            var latestTag = await GetLatestReleaseTagAsync();
            if (latestTag != null)
                Console.WriteLine($"Latest release: {latestTag}");
            else
                Console.WriteLine("Could not fetch latest release.");
        }
    }
}