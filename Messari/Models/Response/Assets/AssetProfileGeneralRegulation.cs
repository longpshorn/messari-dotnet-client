using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileGeneralRegulation
    {
        [JsonProperty("regulatory_details")]
        public string RegulatoryDetails { get; set; }
        [JsonProperty("sfar_score")]
        public double SfarScore { get; set; }
        [JsonProperty("sfar_summary")]
        public string SfarSummary { get; set; }
    }
}