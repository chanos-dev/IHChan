using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Environment
{
    internal class CovidEnvironment
    {
        /// <summary>
        /// Base URL
        /// </summary>
        internal static string BASE_URL => @"http://openapi.data.go.kr";

        /// <summary>
        /// Response Json Node
        /// </summary>
        internal static string BASE_JSON_TOP_OBJECT => "response/body/items/item";        
    }
}
