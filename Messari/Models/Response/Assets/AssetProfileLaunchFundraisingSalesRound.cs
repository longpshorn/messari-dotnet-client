using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class AssetProfileLaunchFundraisingSalesRound
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("start_date")] 
        public DateTime StartDate { get; set; }
        [JsonProperty("type")] 
        public string Type { get; set; }
        [JsonProperty("details")] 
        public string Details { get; set; }
        [JsonProperty("end_date")] 
        public DateTime EndDate { get; set; }
        [JsonProperty("native_tokens_allocated")] 
        public long NativeTokensAllocated { get; set; }
        [JsonProperty("asset_collected")] 
        public string AssetCollected { get; set; }
        [JsonProperty("price_per_token_in_asset")] 
        public double PricePerTokenInAsset { get; set; }
        [JsonProperty("equivalent_price_per_token_in_USD")] 
        public double EquivalentPricePerTokenInUsd { get; set; }
        [JsonProperty("amount_collected_in_asset")] 
        public double AmountCollectedInAsset { get; set; }
        [JsonProperty("amount_collected_in_USD")] 
        public double AmountCollectedInUsd { get; set; }
        [JsonProperty("is_kyc_required")] 
        public bool IsKycRequired { get; set; }
        [JsonProperty("restricted_jurisdictions")] 
        public List<string> RestrictedJurisdictions { get; set; } = new List<string>();
    }
}