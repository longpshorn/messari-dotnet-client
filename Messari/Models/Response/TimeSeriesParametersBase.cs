using System;
using System.Collections.Generic;
using Messari.Helper;
using Messari.Models.Request;
using Newtonsoft.Json;

namespace Messari.Models.Response
{
    public class TimeSeriesParametersBase
    {
        [JsonProperty("start")]
        public DateTime Start { get; set; }
        [JsonProperty("end")]
        public DateTime End { get; set; }
        [JsonProperty("interval")]
        [JsonConverter(typeof(IntervalConverter))]
        public Interval Interval { get; set; }
        [JsonProperty("order")]
        [JsonConverter(typeof(OrderConverter))]
        public Order Order { get; set; }
        [JsonProperty("format")]
        [JsonConverter(typeof(FormatConverter))]
        public Format Format { get; set; }
        [JsonProperty("timestamp_format")]
        [JsonConverter(typeof(TimestampFormatConverter))]
        public TimestampFormat TimestampFormat { get; set; }
        [JsonProperty("columns")]
        public List<string> Columns { get; set; }
    }
}