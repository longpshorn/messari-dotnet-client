using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileTechnologyClientRepository
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("link")] 
        public string Link { get; set; }
        [JsonProperty("license_type")] 
        public string LicenseType { get; set; }
    }
}