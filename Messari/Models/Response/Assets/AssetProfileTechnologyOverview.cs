using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileTechnologyOverview
    {
        [JsonProperty("technology_details")]
        public string TechnologyDetails { get; set; }
        [JsonProperty("client_repositories")]
        public List<AssetProfileTechnologyClientRepository> ClientRepositories { get; set; } = new List<AssetProfileTechnologyClientRepository>();
    }
}