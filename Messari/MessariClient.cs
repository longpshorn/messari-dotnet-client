using System;
using System.Net.Http;
using Messari.Helper;
using Messari.Service;

namespace Messari
{
    public class MessariClient : IDisposable
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;
        private readonly string _apiToken;

        private protected readonly ExecutorRest _executor;

        private IAssetService _assetService;
        private IMarketService _marketService;
        private INewsService _newsService;

        /// <summary>
        /// <see cref="https://omnieq.com/about#api-endpoint-account"/>
        /// </summary>
        public IAssetService Asset => _assetService
            ?? (_assetService = new AssetService(_executor));
        public IMarketService Market => _marketService
            ?? (_marketService = new MarketService(_executor));
        public INewsService News => _newsService
            ?? (_newsService = new NewsService(_executor));

        /// <summary>
        /// Creates a new OmniEqClient.
        /// </summary>
        /// <param name="apiToken">The api token associated with your account.</param>
        public MessariClient(string apiToken)
        {
            if (string.IsNullOrWhiteSpace(apiToken))
            {
                throw new ArgumentException("Api token must be provided to the Messari Client.");
            }

            _apiToken = apiToken;
            _baseUrl = "https://data.messari.io/api/";

            _client = new HttpClient
            {
                BaseAddress = new Uri(_baseUrl)
            };
            _client.DefaultRequestHeaders.Add("User-Agent", "MessariSharp Messari .Net");
            _client.DefaultRequestHeaders.Add("x-messari-api-key", _apiToken);

            _executor = new ExecutorRest(_client);
        }

        private bool _disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _client.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
