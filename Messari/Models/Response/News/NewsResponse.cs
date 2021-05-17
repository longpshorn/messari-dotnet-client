using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.News
{
    public class NewsResponse
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("title")] 
        public string Title { get; set; }
        [JsonProperty("content")] 
        public string Content { get; set; }
        [JsonProperty("reference_title")] 
        public string ReferenceTitle { get; set; }
        [JsonProperty("published_at")] 
        public DateTime PublishedAt { get; set; }
        [JsonProperty("url")] 
        public string Url { get; set; }
        [JsonProperty("author")] 
        public NewsAuthor Author { get; set; }
        [JsonProperty("tags")] 
        public List<string> Tags { get; set; } = new List<string>();
        [JsonProperty("references")] 
        public List<SoureAttribution> References { get; set; } = new List<SoureAttribution>();
    }
}