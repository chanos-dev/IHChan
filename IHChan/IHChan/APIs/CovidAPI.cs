using IHChan.Environment;
using IHChan.Model;
using IHChan.Options;
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

        protected override string Accept => "application/xml";

        protected override string ContentType => "application/xml";

        protected override string UserAgent => "covid";

        /// <summary>
        /// 공공데이터활용지원센터_보건복지부 코로나19 감염 현황
        /// </summary>
        /// <param name="start">데이터 생성일 시작범위</param>
        /// <param name="end">데이터 생성일 종료범위</param>
        /// <returns></returns>
        public List<InformationOfCovidHomeCountryJson> GetHomeCountryCovidState(string start, string end)
        {
            APIURL = new[] { "getCovid19InfStateJson" };
            
            RequestParams = new Dictionary<string, string>()
            {
                { "serviceKey", Option.Instance.APIKey },
                { "pageNo", "1" },
                { "numOfRows", "10" },
                { "startCreateDt", start },
                { "endCreateDt", end }
            };

            return RequestAPI.APICaller<List<InformationOfCovidHomeCountryJson>>(this, Method.GET);
        }

        /// <summary>
        /// 공공데이터활용지원센터_보건복지부 코로나19 시·도발생 현황
        /// </summary>
        /// <param name="start">데이터 생성일 시작범위</param>
        /// <param name="end">데이터 생성일 종료범위</param>
        /// <returns></returns>
        public List<InformationOfCovidSidoJson> GetSidoCovidState(string start, string end)
        {
            APIURL = new[] { "getCovid19SidoInfStateJson" };

            RequestParams = new Dictionary<string, string>()
            {
                { "serviceKey", Option.Instance.APIKey },
                { "pageNo", "1" },
                { "numOfRows", "10" },
                { "startCreateDt", start },
                { "endCreateDt", end }
            };

            return RequestAPI.APICaller<List<InformationOfCovidSidoJson>>(this, Method.GET);
        }

        /// <summary>
        /// 공공데이터활용지원센터_보건복지부 코로나19해외발생 현황
        /// </summary>
        /// <param name="start">데이터 생성일 시작범위</param>
        /// <param name="end">데이터 생성일 종료범위</param>
        /// <returns></returns>
        public List<InformationOfCovidOverseasJson> GetOverseasCovidState(string start, string end)
        {
            APIURL = new[] { "getCovid19NatInfStateJson" };

            RequestParams = new Dictionary<string, string>()
            {
                { "serviceKey", Option.Instance.APIKey },
                { "pageNo", "1" },
                { "numOfRows", "10" },
                { "startCreateDt", start },
                { "endCreateDt", end }
            };

            return RequestAPI.APICaller<List<InformationOfCovidOverseasJson>>(this, Method.GET);
        }
    }
}
