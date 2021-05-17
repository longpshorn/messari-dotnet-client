using System;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class Asset
    {

        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}