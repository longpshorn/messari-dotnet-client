using System.Linq;
using System.Threading.Tasks;
using Messari;
using MessariTest.Helpers;
using NUnit.Framework;

namespace MessariEqTest
{
    public class AssetServiceTests
    {
        private MessariClient _client;
        private MessariClientConfiguration _configuration;

        [SetUp]
        public void Init()
        {
            _configuration = TestHelper.GetApplicationConfiguration(TestContext.CurrentContext.TestDirectory);
        }

        [SetUp]
        public void Setup()
        {
            _client = new MessariClient(_configuration.ApiKey);
        }

        [Test]
        public async Task GetAllAssetsAsyncTest()
        {
            var response = await _client.Asset
                .GetAllAssetsAsync();

            Assert.AreEqual(response.Status.ErrorCode, 0);
            Assert.IsNotNull(response.Data);
            Assert.GreaterOrEqual(response.Data.Count(), 20);
            Assert.IsNotNull(response.Data.First());
        }

        [Test]
        [TestCase("btc")]
        public async Task GetAssetAsyncTest(string assetKey)
        {
            var response = await _client.Asset
                .GetAssetAsync(assetKey);

            Assert.AreEqual(response.Status.ErrorCode, 0);
            Assert.IsNotNull(response.Data);
        }

        [Test]
        [TestCase("btc")]
        public async Task GetAssetProfileAsyncTest(string assetKey)
        {
            var response = await _client.Asset
                .GetAssetProfileAsync(assetKey);

            Assert.AreEqual(response.Status.ErrorCode, 0);
            Assert.IsNotNull(response.Data);
        }

        [Test]
        [TestCase("btc")]
        public async Task GetAssetMetricsAsyncTest(string assetKey)
        {
            var response = await _client.Asset
                .GetAssetMetricsAsync(assetKey);

            Assert.AreEqual(response.Status.ErrorCode, 0);
            Assert.IsNotNull(response.Data);
        }

        [Test]
        [TestCase("btc")]
        public async Task GetAssetMarketDataAsyncTest(string assetKey)
        {
            var response = await _client.Asset
                .GetAssetMarketDataAsync(assetKey);

            Assert.AreEqual(response.Status.ErrorCode, 0);
            Assert.IsNotNull(response.Data);
        }

        [Test]
        public async Task GetAssetMetricsListAsyncTest()
        {
            var response = await _client.Asset
                .GetMetricsListAsync();

            Assert.AreEqual(response.Status.ErrorCode, 0);
            Assert.IsNotNull(response.Data);
        }

        [Test]
        [TestCase("btc", "price")]
        public async Task GetAssetTimeSeriesAsyncTest(string assetKey, string metricId)
        {
            var start = TimingHelper.GetLastWednesday();
            var end = TimingHelper.GetLastThursday();
            var response = await _client.Asset
                .GetAssetTimeSeriesAsync(assetKey, metricId, start, end);

            Assert.AreEqual(response.Status.ErrorCode, 0);
            Assert.IsNotNull(response.Data);
        }
    }
}