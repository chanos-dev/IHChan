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

        /// <summary>
        /// 공공데이터활용지원센터_보건복지부 코로나19 감염 현황 
        /// </summary>
        /// <param name="start">데이터 생성일 시작범위</param>
        /// <param name="end">데이터 생성일 종료범위</param>
        /// <returns></returns>
        public List<InformationOfCovidHomeCountryJson> GetHomeCountryCovidState(string start, string end)
        {
            start = CheckSameDate(start, end);
            start = start.Replace("-", "");
            end = end.Replace("-", "");

            return CovidAPI.GetHomeCountryCovidState(start, end);
        }


        /// <summary>
        /// 공공데이터활용지원센터_보건복지부 코로나19 시·도발생 현황
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public List<InformationOfCovidSidoJson> GetSidoCovidState(string start, string end)
        {
            start = CheckSameDate(start, end);
            start = start.Replace("-", "");
            end = end.Replace("-", "");
            
            return CovidAPI.GetSidoCovidState(start, end);           
        }

        /// <summary>
        /// 공공데이터활용지원센터_보건복지부 코로나19해외발생 현황
        /// </summary>
        /// <param name="start">데이터 생성일 시작범위</param>
        /// <param name="end">데이터 생성일 종료범위</param>
        /// <returns></returns>
        public List<InformationOfCovidOverseasJson> GetOverseasCovidState(string start, string end)
        {
            start = CheckSameDate(start, end);
            start = start.Replace("-", "");
            end = end.Replace("-", "");

            return CovidAPI.GetOverseasCovidState(start, end);
        }

        private string CheckSameDate(string start, string end)
        {
            if (start.Equals(end))
            {
                if (DateTime.TryParse(start, out DateTime result))
                {
                    return $"{result.AddDays(-1):d}";
                }
            }

            return start;
        }
    }
}
