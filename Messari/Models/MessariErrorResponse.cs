using Newtonsoft.Json;

namespace Messari.Models
{
    public class MessariErrorResponse
    {
        [JsonProperty("status")]
        public MessariStatusResponse Status { get; set; }
    }
}
