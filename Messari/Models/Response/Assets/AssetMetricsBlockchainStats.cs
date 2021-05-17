using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetMetricsBlockchainStats
    {
        [JsonProperty("transaction_volume")] 
        public double TransactionVolume { get; set; }
        [JsonProperty("nvt")] 
        public double Nvt { get; set; }
        [JsonProperty("sum_of_fees")] 
        public double SumOfFees { get; set; }
        [JsonProperty("median_tx_value")] 
        public double MedianTxValue { get; set; }
        [JsonProperty("median_tx_fee")] 
        public double MedianTxFee { get; set; }
        [JsonProperty("count_of_active_addresses")] 
        public int CountOfActiveAddresses { get; set; }
        [JsonProperty("count_of_tx")] 
        public int CountOfTx { get; set; }
        [JsonProperty("count_of_payments")] 
        public int CountOfPayments { get; set; }
        [JsonProperty("new_issuance")] 
        public double NewIssuance { get; set; }
        [JsonProperty("average_difficulty")] 
        public double AverageDifficulty { get; set; }
        [JsonProperty("kilobytes_added")] 
        public double KilobytesAdded { get; set; }
        [JsonProperty("count_of_blocks_added")] 
        public int CountOfBlocksAdded { get; set; }
        [JsonProperty("supply_moved_off_chain")]
        public int SupplyMovedOffChain { get; set; }
    }
}
