using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Extentions
{
    public static class ExtentionsCollection
    {
        public static bool IsAny<T>(this IEnumerable<T> collect)
        {
            return (collect != null && collect.Any());
        }
    }
}
