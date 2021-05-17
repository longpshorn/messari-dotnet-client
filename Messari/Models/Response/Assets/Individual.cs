using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class Individual
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
    }
}
