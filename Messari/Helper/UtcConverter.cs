using System;
using Newtonsoft.Json;

namespace Messari.Helper
{
    public class UtcConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) { return null; }
            var dt = DateTime.Parse(reader.Value.ToString());
            var offset = new DateTimeOffset(dt);
            var utc = offset.ToUniversalTime();
            return utc.DateTime;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
