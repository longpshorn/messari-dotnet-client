using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Messari.Models;
using Polly;
using Polly.Retry;

namespace Messari.Helper
{
    internal class ExecutorRest : ExecutorBase
    {
        private readonly HttpClient _client;
        private readonly AsyncRetryPolicy<HttpResponseMessage> _exponentialBackOffPolicy;

        internal readonly JsonSerializerSettings _jsonSerializerSettings;

        public ExecutorRest(HttpClient client)
            : base()
        {
            _client = client;
            _exponentialBackOffPolicy = ExponentialBackOffPolicy(50);

            _jsonSerializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        public async ValueTask<MessariResponse<T>> ExecuteAsync<T>(
            string urlPattern,
            QueryStringBuilder qsb
        )
            where T : class
        {
            ValidateAndProcessParams(ref urlPattern, ref qsb);

            var content = string.Empty;

            using var responseContent = await _exponentialBackOffPolicy.ExecuteAsync(
                () => _client.GetAsync($"{urlPattern}{qsb.Build()}")
            ).ConfigureAwait(false);
            try
            {
                content = await responseContent.Content.ReadAsStringAsync().ConfigureAwait(false);
                return content.ToResponse<T>(_jsonSerializerSettings);
            }
            catch (JsonException ex)
            {
                throw new JsonException(content, ex);
            }
        }

        public async ValueTask<MessariResponse<T>> NoParamExecuteAsync<T>(string url)
            where T : class
        {
            var qsb = new QueryStringBuilder();

            return await ExecuteAsync<T>(url, qsb).ConfigureAwait(false);
        }

        public async ValueTask<MessariResponse<T>> SymbolExecuteAsync<T>(string urlPattern, string symbol, QueryStringBuilder qsb = null)
            where T : class
        {
            qsb = qsb ?? new QueryStringBuilder();
            qsb.Add("symbol", symbol);

            return await ExecuteAsync<T>(urlPattern, qsb).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates an 'Exponential BackOff' strategy that helps with TooManyRequests faults (Http Code = 429) when communicating
        /// with the OmniEq Service.
        /// </summary>
        /// <returns></returns>
        private static AsyncRetryPolicy<HttpResponseMessage> ExponentialBackOffPolicy(int retryAttempts = 10)
        {
            var random = new Random();

            // Define our waitAndRetry policy: retry n times with an exponential back-off in case the IEXCloud API throttles us for too many requests.
            var waitAndRetryPolicy = Policy
                .HandleResult<HttpResponseMessage>(e =>
                {
                    if (e.StatusCode == HttpStatusCode.ServiceUnavailable || e.StatusCode == (HttpStatusCode)429)
                    {
                        return true;
                    }

                    var content = e.Content.ReadAsStringAsync().Result;
                    if (content.Contains("\"error_code\""))
                    {
                        var serializerSettings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        };
                        var response = JsonConvert.DeserializeObject<MessariErrorResponse>(content, serializerSettings);
                        var shouldBackoff = (
                            response.Status.ErrorCode == (int)HttpStatusCode.TooManyRequests
                        );
                        return shouldBackoff;
                    }
                    return false;
                })
                .WaitAndRetryAsync(
                    retryAttempts, // Retry n times with a delay between retries before ultimately giving up
                    attempt => TimeSpan.FromMilliseconds(250 * Math.Pow(2, attempt) * (1 + random.NextDouble())), // Use Exponential Back off with some randomness to better distribute calls
                    (exception, calculatedWaitDuration, attempt, context) => { Debug.WriteLine($"Attempt: {attempt}: OmniEq API is throttling our requests. Automatically delaying for {calculatedWaitDuration.TotalMilliseconds}ms"); }
                );

            return waitAndRetryPolicy;
        }
    }
}
