using System.Linq;
using System.Threading.Tasks;
using Messari;
using MessariTest.Helpers;
using NUnit.Framework;

namespace MessariEqTest
{
    public class MarketServiceTests
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
        public async Task GetAllMarketsAsyncTest()
        {
            var response = await _client.Market
                .GetAllMarketsAsync();

            Assert.AreEqual(response.Status.ErrorCode, 0);
            Assert.IsNotNull(response.Data);
            Assert.GreaterOrEqual(response.Data.Count(), 20);
            Assert.IsNotNull(response.Data.First());
        }

        [Test]
        [TestCase("binance-btc-usdt", "price")]
        public async Task GetMarketTimeSeriesAsyncTest(string metricKey, string metricId)
        {
            var start = TimingHelper.GetLastWednesday();
            var end = TimingHelper.GetLastThursday();
            var response = await _client.Market
                .GetMarketTimeSeriesAsync(metricKey, metricId, start, end);

            Assert.AreEqual(response.Status.ErrorCode, 0);
            Assert.IsNotNull(response.Data);
        }
    }
}