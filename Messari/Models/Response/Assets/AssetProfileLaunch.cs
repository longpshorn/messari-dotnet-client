using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileLaunch
    {
        [JsonProperty("general")]
        public AssetProfileLaunchGeneral General { get; set; }
        [JsonProperty("fundraising")]
        public AssetProfileLaunchFundraising Fundraising { get; set; }
        [JsonProperty("initial_distribution")]
        public AssetProfileLaunchInitialDistribution InitialDistribution { get; set; }
    }
}