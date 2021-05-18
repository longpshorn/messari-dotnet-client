using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Messari.Helper;
using Messari.Models;
using Messari.Models.Request;
using Messari.Models.Response.Assets;

namespace Messari.Service
{
    public interface IAssetService
    {
        /// <summary>
        /// Get the paginated list of all assets and their metrics and profiles.
        /// <see cref="https://messari.io/api/docs#operation/Get%20all%20Assets%20V2"/>
        /// </summary>
        /// <param name="page"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        ValueTask<MessariResponse<IEnumerable<AssetResponse>>> GetAllAssetsAsync(int page = 1, string sort = "id", int limit = 20);

        /// <summary>
        /// Get basic metadata for an asset.
        /// <see cref="https://messari.io/api/docs#operation/Get%20Asset"/>
        /// </summary>
        /// <returns></returns>
        ValueTask<MessariResponse<AssetResponse>> GetAssetAsync(string assetKey);

        /// <summary>
        /// Get all of our qualitative information for an asset.
        /// <see cref="https://messari.io/api/docs#operation/Get%20Asset%20Profile%20V2"/>
        /// </summary>
        /// <param name="assetKey"></param>
        /// <param name="asMarkdown"></param>
        /// <returns></returns>
        ValueTask<MessariResponse<AssetResponse>> GetAssetProfileAsync(string assetKey, bool asMarkdown = false);

        /// <summary>
        /// Get the latest market data for an asset. This data is also included in the metrics endpoint, but if all you need is market-data, use this.
        /// <see cref="https://messari.io/api/docs#operation/Get%20Asset%20Metrics"/>
        /// </summary>
        /// <param name="assetKey"></param>
        /// <returns></returns>
        ValueTask<MessariResponse<AssetMetrics>> GetAssetMetricsAsync(string assetKey);

        /// <summary>
        /// Get the latest market data for an asset. This data is also included in the metrics endpoint, but if all you need is market-data, use this.
        /// <see cref="https://messari.io/api/docs#operation/Get%20Asset%20Market%20Data"/>
        /// </summary>
        /// <param name="assetKey"></param>
        /// <returns></returns>
        ValueTask<MessariResponse<AssetMetrics>> GetAssetMarketDataAsync(string assetKey);

        /// <summary>
        /// Lists all of the available timeseries metric IDs for assets.
        /// <see cref="https://messari.io/api/docs#operation/List%20asset%20timeseries%20metric%20IDs"/>
        /// </summary>
        /// <returns></returns>
        ValueTask<MessariResponse<AssetMetricsList>> GetMetricsListAsync();

        /// <summary>
        /// Retrieve historical timeseries data for an asset.
        /// <see cref="https://messari.io/api/docs#operation/Get%20Asset%20timeseries"/>
        /// </summary>
        /// <param name="assetKey"></param>
        /// <param name="metricId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="interval"></param>
        /// <param name="columns"></param>
        /// <param name="order"></param>
        /// <param name="format"></param>
        /// <param name="timestampFormat"></param>
        /// <returns></returns>
        ValueTask<MessariResponse<TimeSeriesAssetResponse>> GetAssetTimeSeriesAsync(
            string assetKey,
            string metricId,
            DateTime start,
            DateTime end,
            Interval interval = Interval._1d,
            string columns = "open,close",
            Order order = Order.Asc,
            Format format = Format.Json,
            TimestampFormat timestampFormat = TimestampFormat.Rfc3339
        );
    }

    public class AssetService : IAssetService
    {
        private readonly ExecutorRest _executor;

        internal AssetService(ExecutorRest executor)
        {
            _executor = executor;
        }

        public async ValueTask<MessariResponse<IEnumerable<AssetResponse>>> GetAllAssetsAsync(int page = 1, string sort = "id", int limit = 20)
        {
            const string urlPattern = "v2/assets";
            var qsb = new QueryStringBuilder();
            qsb.Add("page", page);
            qsb.Add("sort", sort);
            qsb.Add("limit", limit);
            return await _executor.ExecuteAsync<IEnumerable<AssetResponse>>(urlPattern, qsb).ConfigureAwait(false);
        }

        public async ValueTask<MessariResponse<AssetResponse>> GetAssetAsync(string assetKey)
        {
            var urlPattern = $"v1/assets/{assetKey}";
            return await _executor.NoParamExecuteAsync<AssetResponse>(urlPattern).ConfigureAwait(false);
        }

        public async ValueTask<MessariResponse<AssetResponse>> GetAssetProfileAsync(string assetKey, bool asMarkdown = false)
        {
            var urlPattern = $"v2/assets/{assetKey}/profile";
            var qsb = new QueryStringBuilder();
            qsb.Add("as-markdown", asMarkdown);
            return await _executor.ExecuteAsync<AssetResponse>(urlPattern, qsb).ConfigureAwait(false);
        }

        public async ValueTask<MessariResponse<AssetMetrics>> GetAssetMetricsAsync(string assetKey)
        {
            var urlPattern = $"v1/assets/{assetKey}/metrics";
            return await _executor.NoParamExecuteAsync<AssetMetrics>(urlPattern).ConfigureAwait(false);
        }

        public async ValueTask<MessariResponse<AssetMetrics>> GetAssetMarketDataAsync(string assetKey)
        {
            var urlPattern = $"v1/assets/{assetKey}/metrics/market-data";
            return await _executor.NoParamExecuteAsync<AssetMetrics>(urlPattern).ConfigureAwait(false);
        }

        public async ValueTask<MessariResponse<AssetMetricsList>> GetMetricsListAsync()
        {
            var urlPattern = $"v1/assets/metrics";
            return await _executor.NoParamExecuteAsync<AssetMetricsList>(urlPattern).ConfigureAwait(false);
        }

        public async ValueTask<MessariResponse<TimeSeriesAssetResponse>> GetAssetTimeSeriesAsync(
            string assetKey,
            string metricId,
            DateTime start,
            DateTime end,
            Interval interval = Interval._1d,
            string columns = "open,close",
            Order order = Order.Asc,
            Format format = Format.Json,
            TimestampFormat timestampFormat = TimestampFormat.Rfc3339
        )
        {
            var urlPattern = $"v1/assets/{assetKey}/metrics/{metricId}/time-series";
            var qsb = new QueryStringBuilder();
            qsb.Add("start", start.ToString("yyyy-MM-dd"));
            qsb.Add("end", end.ToString("yyyy-MM-dd"));
            qsb.Add("interval", interval.GetDescription());
            qsb.Add("columns", columns);
            qsb.Add("order", order.GetDescription());
            qsb.Add("format", format.GetDescription());
            qsb.Add("timestamp-format", timestampFormat.GetDescription());
            return await _executor.ExecuteAsync<TimeSeriesAssetResponse>(urlPattern, qsb).ConfigureAwait(false);
        }
    }
}
