using System;
using Newtonsoft.Json;

namespace Messari.Models.Response.Markets
{
    public class MarketResponse
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("exchange_id")]
        public Guid ExchangeId { get; set; }
        [JsonProperty("base_asset_id")] 
        public Guid BaseAssetId { get; set; }
        [JsonProperty("quote_asset_id")] 
        public Guid QuoteAssetId { get; set; }
        [JsonProperty("class")]
        public string Class { get; set; }
        [JsonProperty("excluded_from_price")]
        public bool ExcludedFromPrice { get; set; }
        [JsonProperty("exchange_name")]
        public string ExchangeName { get; set; }
        [JsonProperty("exchange_slug")]
        public string ExchangeSlug { get; set; }
        [JsonProperty("base_asset_symbol")] 
        public string BaseAssetSymbol { get; set; }
        [JsonProperty("quote_asset_symbol")] 
        public string QuoteAssetSymbol { get; set; }
        [JsonProperty("pair")] 
        public string Pair { get; set; }
        [JsonProperty("price_usd")] 
        public double PriceUsd { get; set; }
        [JsonProperty("volume_last_24_hours")] 
        public double VolumeLast24Hours { get; set; }
        [JsonProperty("deviation_from_vwap_percent")] 
        public double DeviationFromVwapPercent { get; set; }
        [JsonProperty("last_trade_at")] 
        public DateTime LastTradeAt { get; set; }
    }
}