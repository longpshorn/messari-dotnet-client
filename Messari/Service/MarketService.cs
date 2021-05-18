using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Messari.Helper;
using Messari.Models;
using Messari.Models.Request;
using Messari.Models.Response.Markets;

namespace Messari.Service
{
    public interface IMarketService
    {
        /// <summary>
        /// Get the list of all exchanges and pairs that our WebSocket-based market real-time market data API supports.
        /// <see cref="https://messari.io/api/docs#operation/Get%20all%20Markets"/>
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        ValueTask<MessariResponse<IEnumerable<MarketResponse>>> GetAllMarketsAsync(int page = 1);

        /// <summary>
        /// Retrieve historical timeseries data for a market.
        /// <see cref="https://messari.io/api/docs#operation/Get%20Market%20timeseries"/>
        /// </summary>
        /// <param name="marketKey"></param>
        /// <param name="metricId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="interval"></param>
        /// <param name="columns"></param>
        /// <param name="order"></param>
        /// <param name="format"></param>
        /// <param name="timestampFormat"></param>
        /// <returns></returns>
        ValueTask<MessariResponse<TimeSeriesMarketResponse>> GetMarketTimeSeriesAsync(
            string marketKey,
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

    public class MarketService : IMarketService
    {
        private readonly ExecutorRest _executor;

        internal MarketService(ExecutorRest executor)
        {
            _executor = executor;
        }

        public async ValueTask<MessariResponse<IEnumerable<MarketResponse>>> GetAllMarketsAsync(int page = 1)
        {
            const string urlPattern = "v1/markets";
            var qsb = new QueryStringBuilder();
            qsb.Add("page", page);
            return await _executor.ExecuteAsync<IEnumerable<MarketResponse>>(urlPattern, qsb).ConfigureAwait(false);
        }

        public async ValueTask<MessariResponse<TimeSeriesMarketResponse>> GetMarketTimeSeriesAsync(
            string marketKey,
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
            var urlPattern = $"v1/markets/{marketKey}/metrics/{metricId}/time-series";
            var qsb = new QueryStringBuilder();
            qsb.Add("start", start.ToString("yyyy-MM-dd"));
            qsb.Add("end", end.ToString("yyyy-MM-dd"));
            qsb.Add("interval", interval.GetDescription());
            qsb.Add("columns", columns);
            qsb.Add("order", order.GetDescription());
            qsb.Add("format", format.GetDescription());
            qsb.Add("timestamp-format", timestampFormat.GetDescription());
            return await _executor.ExecuteAsync<TimeSeriesMarketResponse>(urlPattern, qsb).ConfigureAwait(false);
        }
    }
}
