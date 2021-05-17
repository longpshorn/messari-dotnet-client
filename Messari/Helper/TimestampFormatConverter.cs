using System;
using Messari.Models.Request;
using Newtonsoft.Json;

namespace Messari.Helper
{
    public class TimestampFormatConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) { return null; }
            var result = ((string)reader.Value).GetEnumFromDescription<TimestampFormat>();
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
