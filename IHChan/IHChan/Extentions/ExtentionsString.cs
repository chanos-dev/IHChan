using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Extentions
{
    public static class ExtentionsString
    {
        public static int ConvertToInt(this string str)
        {
            if (int.TryParse(str, out int result)) 
                return result;

            return -1;
        }
    }
}
