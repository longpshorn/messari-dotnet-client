using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetMetricsSupply
    {
        [JsonProperty("y_2050")] 
        public double Y2050 { get; set; }
        [JsonProperty("y_2050_percent_issued")] 
        public double Y2050PercentIssued { get; set; }
        [JsonProperty("supply_yplus_10")] 
        public double SupplyYPlus10 { get; set; }
        [JsonProperty("y_plus10_issued_percent")] 
        public double YPlus10IssuedPercent { get; set; }
        [JsonProperty("liquid")] 
        public double Liquid { get; set; }
        [JsonProperty("circulating")] 
        public double Circulating { get; set; }
        [JsonProperty("stock_to_flow")]
        public double StockToFlow { get; set; }
    }
}
