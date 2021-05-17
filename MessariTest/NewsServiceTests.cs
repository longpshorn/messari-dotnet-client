using System.Linq;
using System.Threading.Tasks;
using Messari;
using MessariTest.Helpers;
using NUnit.Framework;

namespace MessariEqTest
{
    public class NewsServiceTests
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
        public async Task GetAllNewsAsyncTest()
        {
            var response = await _client.News
                .GetAllNewsAsync();

            Assert.AreEqual(response.Status.ErrorCode, 0);
            Assert.IsNotNull(response.Data);
            Assert.GreaterOrEqual(response.Data.Count(), 20);
            Assert.IsNotNull(response.Data.First());
        }

        [Test]
        [TestCase("xrp")]
        public async Task GetMarketTimeSeriesAsyncTest(string assetKey)
        {
            var response = await _client.News
                .GetAssetNewsAsync(assetKey);

            Assert.AreEqual(response.Status.ErrorCode, 0);
            Assert.IsNotNull(response.Data);
        }
    }
}