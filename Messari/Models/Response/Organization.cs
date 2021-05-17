using Newtonsoft.Json;

namespace Messari.Models.Response
{
    public class Organization
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("name")] 
        public string Name { get; set; }
        [JsonProperty("logo")] 
        public string Logo { get; set; }
        [JsonProperty("description")] 
        public string Description { get; set; }
    }
}