using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IHChan.Converter
{
    class XmlConverter
    {
        public static string ConvertXmlToJson(string xml)
        {
            if (string.IsNullOrEmpty(xml))
                throw new ArgumentException("'string xml' parameter is blank.");

            var doc = new XmlDocument();
            doc.LoadXml(xml);

            return JsonConvert.SerializeXmlNode(doc);
        }
    }
}
