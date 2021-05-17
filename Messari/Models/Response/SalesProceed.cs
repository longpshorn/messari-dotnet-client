using Newtonsoft.Json;

namespace Messari.Models.Response
{
    public class SalesProceed
    {
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("amount_in_percentage")]
        public double AmountInPercentage { get; set; }
    }
}