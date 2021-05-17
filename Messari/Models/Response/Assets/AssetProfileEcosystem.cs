using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileEcosystem
    {
        [JsonProperty("assets")]
        public List<Asset> Assets { get; set; }
        [JsonProperty("organizations")]
        public List<Organization> Organizations { get; set; }
    }
}