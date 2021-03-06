using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileContributors
    {
        [JsonProperty("individuals")]
        public List<Individual> Individuals { get; set; }
        [JsonProperty("organizations")] 
        public List<Organization> Organizations { get; set; }
    }
}