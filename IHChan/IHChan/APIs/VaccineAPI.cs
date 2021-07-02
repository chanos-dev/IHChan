using IHChan.Environment;
using IHChan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.APIs
{
    internal  class VaccineAPI : BaseAPI
    {
        protected override string BaseURL => CovidEnvironment.VACCIN_URL;

        protected override string[] MiddleURL => new[] { "irgd", "cov19stats.do" };

        protected override string Accept => "application/xml";

        protected override string ContentType => "application/xml";

        protected override string UserAgent => "covid";

        /// <summary>
        /// 백신 예방접종 현황
        /// </summary>
        /// <param name="vaccineType">all, sido</param>
        /// <returns></returns>
        public List<Vaccine> GetVaccine(VaccineType vaccineType)
        {
            RequestParams = new Dictionary<string, string>()
            {
                { "list", $"{vaccineType.ToString().ToLower()}" },
            };

            return RequestAPI.APICaller<List<Vaccine>>(this, Method.GET);
        }
    }
}
