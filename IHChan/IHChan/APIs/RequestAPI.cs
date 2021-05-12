using IHChan.Converter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.APIs
{
    internal class RequestAPI
    {
        internal static async Task<T> APICaller<T>(BaseAPI api, Method method)
            where T : class
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json");

                    // GET TEST-CODE 
                    var response = await client.GetAsync(api.RequestURL);
                    response.EnsureSuccessStatusCode();

                    var result = response.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<T>(result, new CovidConverter<T>());
                }
            }
            catch
            {

            }
            

            return default(T);
        }
    }
}
