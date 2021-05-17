using System.Diagnostics;
using Newtonsoft.Json;

namespace Messari.Models
{
    /// <summary>
    /// Response to query, either containing data, or an error message
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MessariResponse<T>
    {
        /// <summary>
        /// Data returned by OmniEq.
        /// </summary>
        [JsonProperty("data")]
        public T Data { get; set; }

        /// <summary>
        /// Status returned by OmniEq.
        /// </summary>
        [JsonProperty("status")]
        public MessariStatusResponse Status { get; set; }
    }

    public static class MessariResponseExtensions
    {
        public static MessariResponse<T> ToResponse<T>(this string content, JsonSerializerSettings serializerSettings)
            where T : class
        {
            Debug.WriteLine("Successful Request");
            var result = JsonConvert.DeserializeObject<MessariResponse<T>>(content, serializerSettings);
            return result;
        }
    }
}
