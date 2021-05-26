using IHChan.Environment;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Converter
{
    internal class CovidConverter<T> : JsonConverter
        where T : class
    {
        public override bool CanConvert(Type objectType) => typeof(T) == objectType; 

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JToken.ReadFrom(reader) is JToken token)
            {
                var clearObject = GetChildObject(token); 

                return clearObject?.ToObject<T>();
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            return;
        }

        private JToken GetChildObject(JToken token)
        {
            try
            {
                var parentItems = CovidEnvironment.BASE_JSON_TOP_OBJECT.Split('/');
                var headerItems = CovidEnvironment.HEADER_JSON_OBJECT.Split('/');

                var temp = token.DeepClone();

                foreach (var p in headerItems)
                {
                    temp = temp[p];
                }

                if ($"{temp.Values().FirstOrDefault()}" != "00")
                    return null;

                foreach (var p in parentItems)
                {
                    token = token[p];
                }
            }
            catch
            {
                throw;
            }

            return token;
        }
    }
}
