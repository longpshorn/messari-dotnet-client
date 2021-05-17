using System.ComponentModel;

namespace Messari.Models.Request
{
    public enum Order
    {
        [Description("ascending")]
        Asc = 1,
        [Description("descending")]
        Desc
    }
}