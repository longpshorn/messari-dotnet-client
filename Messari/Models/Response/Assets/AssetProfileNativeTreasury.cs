using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileNativeTreasury
    {
        [JsonProperty("treasury_usage_details")]
        public string TreasuryUsageDetails { get; set; }
        [JsonProperty("accounts")]
        public List<NativeTreasuryAccount> Accounts { get; set; } = new List<NativeTreasuryAccount>();
    }
}