using System;
using Newtonsoft.Json;

namespace Messari.Models.Response
{
    public class SecurityAudit
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("date")] 
        public DateTime Date { get; set; }
        [JsonProperty("type")] 
        public string Type { get; set; }
        [JsonProperty("details")] 
        public string Details { get; set; }
    }
}