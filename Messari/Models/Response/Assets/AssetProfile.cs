using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfile
    {
        [JsonProperty("general")]
        public AssetProfileGeneral General { get; set; }
        [JsonProperty("contributors")] 
        public AssetProfileContributors Contributors { get; set; }
        [JsonProperty("advisors")] 
        public AssetProfileAdvisors Advisors { get; set; }
        [JsonProperty("investors")] 
        public AssetProfileInvestors Investors { get; set; }
        [JsonProperty("ecosystem")] 
        public AssetProfileEcosystem Ecosystem { get; set; }
        [JsonProperty("economics")] 
        public AssetProfileEconomics Economics { get; set; }
        [JsonProperty("technology")] 
        public AssetProfileTechnology Technology { get; set; }
        [JsonProperty("governance")] 
        public AssetProfileGovernance Governance { get; set; }
    }
}
