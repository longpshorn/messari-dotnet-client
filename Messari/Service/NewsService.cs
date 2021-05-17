using System.Collections.Generic;
using System.Threading.Tasks;
using Messari.Helper;
using Messari.Models;
using Messari.Models.Response.News;

namespace Messari.Service
{
    public interface INewsService
    {
        /// <summary>
        /// Get the latest (paginated) news and analysis for all assets.
        /// <see cref="https://messari.io/api/docs#operation/Get%20all%20News"/>
        /// <param name="page"></param>
        /// <param name="asMarkdown"></param>
        /// </summary>
        /// <returns></returns>
        ValueTask<MessariResponse<IEnumerable<NewsResponse>>> GetAllNewsAsync(int page = 1, bool asMarkdown = false);

        /// <summary>
        /// Get the latest (paginated) news and analysis for an asset.
        /// <see cref="https://messari.io/api/docs#operation/Get%20Market%20timeseries"/>
        /// </summary>
        /// <param name="marketKey"></param>
        /// <returns></returns>
        ValueTask<MessariResponse<IEnumerable<NewsResponse>>> GetAssetNewsAsync(
            string assetKey,
            int page = 1,
            bool asMarkdown = false
        );
    }

    public class NewsService : INewsService
    {
        private readonly ExecutorRest _executor;

        internal NewsService(ExecutorRest executor)
        {
            _executor = executor;
        }

        public async ValueTask<MessariResponse<IEnumerable<NewsResponse>>> GetAllNewsAsync(int page = 1, bool asMarkdown = false)
        {
            const string urlPattern = "v1/news";
            var qsb = new QueryStringBuilder();
            qsb.Add("page", page);
            qsb.Add("as_markdown", asMarkdown);
            return await _executor.ExecuteAsync<IEnumerable<NewsResponse>>(urlPattern, qsb).ConfigureAwait(false);
        }

        public async ValueTask<MessariResponse<IEnumerable<NewsResponse>>> GetAssetNewsAsync(
            string assetKey,
            int page = 1,
            bool asMarkdown = false
        )
        {
            var urlPattern = $"v1/news/{assetKey}";
            var qsb = new QueryStringBuilder();
            qsb.Add("page", page);
            qsb.Add("as_markdown", asMarkdown);
            return await _executor.ExecuteAsync<IEnumerable<NewsResponse>>(urlPattern, qsb).ConfigureAwait(false);
        }
    }
}
