using IHChan.Environment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Attributes
{
    class CovidLocationAttribute : Attribute
    {
        /// <summary>
        /// 지역
        /// </summary>
        public Sido Sido { get; set; }

        public CovidLocationAttribute(Sido sido)
        {
            this.Sido = sido;
        }

        public static string GetSidoAttributeValue(Sido sido)
        {
            var sidoField = typeof(CovidEnvironment).GetFields(BindingFlags.NonPublic | BindingFlags.Static).Where(field =>
            {
                if (field.IsDefined(typeof(CovidLocationAttribute)))
                { 
                    return field.GetCustomAttribute<CovidLocationAttribute>().Sido.HasFlag(sido);
                }

                return false;
            }).FirstOrDefault();

            if (sidoField != null)
                return sidoField.GetValue(typeof(CovidEnvironment)) as string;

            return string.Empty;
        }
    }
}
