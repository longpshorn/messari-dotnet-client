using Newtonsoft.Json;

namespace Messari.Models.Response
{
    public class OfficialLink
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}