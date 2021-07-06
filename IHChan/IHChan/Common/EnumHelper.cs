using IHChan.Attributes;
using IHChan.Environment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Common
{
    internal class EnumHelper
    {
        internal static string GetSidoKRName(string sido)
        {
            if (Enum.TryParse(sido, out Sido result))
            {
                var field = typeof(Sido).GetField(result.ToString());

                if (field.GetCustomAttribute<PropertyKRNameAttribute>() is PropertyKRNameAttribute att) 
                    return att.Name; 

                return string.Empty;
            }

            return string.Empty;
        }
    }
}
