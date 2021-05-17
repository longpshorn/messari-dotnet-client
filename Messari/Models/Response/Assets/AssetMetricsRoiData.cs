using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetMetricsRoiData
    {
        [JsonProperty("percent_change_last_1_week")]
        public double PercentChangeLast1Week { get; set; }
        [JsonProperty("percent_change_last_1_month")]
        public double PercentChangeLast1Month { get; set; }
        [JsonProperty("percent_change_last_3_months")]
        public double PercentChangeLast3Months { get; set; }
        [JsonProperty("percent_change_last_1_year")]
        public double PercentChangeLast1Year { get; set; }
    }
}