using IHChan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.APIs
{
    public class CovidController
    {
        private CovidAPI CovidAPI { get; set; }

        public CovidController()
        {
            CovidAPI = new CovidAPI();
        }

        ////// <summary>
        /// 공공데이터활용지원센터_보건복지부 코로나19 감염 현황
        /// </summary>
        /// <param name="start">데이터 생성일 시작범위</param>
        /// <param name="end">데이터 생성일 종료범위</param>
        /// <returns></returns>
        public List<InformationOfCovidHomeCountryJson> GetHomeCountryCovidState(string start, string end)
        {
            start = start.Replace("-", "");
            end = end.Replace("-", "");

            return CovidAPI.GetHomeCountryCovidState(start, end);
        } 
    }
}
