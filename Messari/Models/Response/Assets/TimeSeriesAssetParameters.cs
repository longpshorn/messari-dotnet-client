using System;
using Newtonsoft.Json;

namespace Messari.Models.Response.Assets
{
    public class TimeSeriesAssetParameters : TimeSeriesParametersBase
    {
        [JsonProperty("asset_key")]
        public string AssetKey { get; set; }
        [JsonProperty("asset_id")]
        public Guid AssetId { get; set; }
    }
}