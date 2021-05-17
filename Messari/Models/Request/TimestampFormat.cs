using System.ComponentModel;

namespace Messari.Models.Request
{
    public enum TimestampFormat
    {
        [Description("unix-milliseconds")]
        UnixMillisecond,
        [Description("unix-second")]
        UnixSecond,
        [Description("rfc3339")]
        Rfc3339
    }
}