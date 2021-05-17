using System;
using System.Collections.Specialized;

namespace Messari.Helper
{
    internal class ExecutorBase
    {
        protected static void ValidateAndProcessParams(ref string urlPattern, ref QueryStringBuilder qsb)
        {
            if (string.IsNullOrWhiteSpace(urlPattern))
            {
                throw new ArgumentException("urlPattern cannot be null");
            }

            qsb = qsb ?? new QueryStringBuilder();
        }
    }
}
