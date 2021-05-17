using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileGeneralOverview
    {
        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }
        [JsonProperty("tagline")]
        public string Tagline { get; set; }
        [JsonProperty("category")] 
        public string Category { get; set; }
        [JsonProperty("sector")] 
        public string Sector { get; set; }
        [JsonProperty("tags")]
        public string Tags { get; set; }
        [JsonProperty("project_details")] 
        public string ProjectDetails { get; set; }
        [JsonProperty("official_links")]
        public List<OfficialLink> OfficialLinks { get; set; } = new List<OfficialLink>();
    }
}