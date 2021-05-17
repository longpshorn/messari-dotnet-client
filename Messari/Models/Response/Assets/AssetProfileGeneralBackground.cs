using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileGeneralBackground
    {
        [JsonProperty("background_details")]
        public string BackgroundDetails { get; set; }
        [JsonProperty("issuing_organizations")]
        public List<Organization> MyProperty { get; set; } = new List<Organization>();
    }
}