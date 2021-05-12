using IHChan.Environment;
using IHChan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.APIs
{
    internal class CovidAPI : BaseAPI
    {
        protected override string BaseURL => CovidEnvironment.BASE_URL;

        protected override string[] MiddleURL => new[] { "openapi", "service", "rest", "Covid19" };

        protected override string Accept => "application/json";

        protected override string ContentType => "application/json";

        protected override string UserAgent => "covid";

        public string GETURL => URL;

        public InformationOfCovidInfStateJson Get1()
        {
            APIURL = new[] { "getCovid19InfStateJson" };

            RequestParams = new Dictionary<string, string>()
            {
                { "serviceKey", "key" },
                { "pageNo", "1" },
                { "numOfRows", "10" },
                { "startCreateDt", "20210511" },
                { "endCreateDt", "20210511" }, 
            };

            return RequestAPI.APICaller<InformationOfCovidInfStateJson>(this, Method.GET).Result; 
        }

        public string Get2()
        {
            APIURL = new[] { "getCovid19SidoInfStateJson" };

            return URL;
        }

        public string Get3()
        {
            APIURL = new[] { "getCovid19NatInfStateJson" };

            return URL;
        }
    }
}
