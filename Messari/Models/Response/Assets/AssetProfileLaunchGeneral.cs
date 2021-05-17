using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileLaunchGeneral
    {
        [JsonProperty("launch_style")]
        public string LaunchStyle { get; set; }
        [JsonProperty("launch_details")]
        public string LaunchDetails { get; set; }
    }
}