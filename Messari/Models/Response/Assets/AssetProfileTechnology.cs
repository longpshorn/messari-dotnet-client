using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileTechnology
    {
        [JsonProperty("overview")]
        public AssetProfileTechnologyOverview Overview { get; set; }
        [JsonProperty("security")]
        public AssetProfileTechnologySecurity Security { get; set; }
    }
}