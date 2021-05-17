using System.ComponentModel;

namespace Messari.Models.Request
{
    public enum Format
    {
        [Description("csv")]
        Csv = 1,
        [Description("json")]
        Json
    }
}