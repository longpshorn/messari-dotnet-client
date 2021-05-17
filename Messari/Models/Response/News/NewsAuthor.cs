using Newtonsoft.Json;

namespace Messari.Models.Response.News
{
    public class NewsAuthor
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}