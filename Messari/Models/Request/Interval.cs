using System.ComponentModel;

namespace Messari.Models.Request
{
    public enum Interval
    {
        [Description("1m")]
        _1m = 1,
        [Description("5m")] 
        _5m,
        [Description("15m")] 
        _15m,
        [Description("30m")] 
        _30m,
        [Description("1h")] 
        _1h,
        [Description("1d")] 
        _1d,
        [Description("1w")] 
        _1w
    }
}