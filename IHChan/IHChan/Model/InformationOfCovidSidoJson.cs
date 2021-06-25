using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Model
{
    /// <summary>
    /// 공공데이터활용지원센터_보건복지부 코로나19 시·도발생 현황 Model
    /// </summary>
    public class InformationOfCovidSidoJson
    {  
        /// <summary>
        /// 게시글번호(국내 시도별 발생현황 고유값)
        /// </summary>
        [JsonProperty("seq")]
        public string Seq { get; set; }

        /// <summary>
        /// 등록일시분초
        /// </summary>
        [JsonProperty("createDt")]
        public DateTime CreateDt { get; set; }

        /// <summary>
        /// 사망자 수
        /// </summary>
        [JsonProperty("deathCnt")]
        public string DeathCnt { get; set; }

        /// <summary>
        /// 시도명(한글)
        /// </summary>
        [JsonProperty("gubun")]
        public string Gubun { get; set; }

        /// <summary>
        /// 시도명(중국어)
        /// </summary>
        [JsonProperty("gubunCn")]
        public string GubunCn { get; set; }

        /// <summary>
        /// 시도명(영어)
        /// </summary>
        [JsonProperty("gubunEn")]
        public string GubunEn { get; set; }

        /// <summary>
        /// 전일대비 증감 수
        /// </summary>
        [JsonProperty("incDec")]
        public string IncDec { get; set; }

        /// <summary>
        /// 격리 해제 수
        /// </summary>
        [JsonProperty("isolClearCnt")]
        public string IsolClearCnt { get; set; }

        /// <summary>
        /// 10만명당 발생률
        /// </summary>
        [JsonProperty("qurRate")]
        public string QurRate { get; set; } 

        /// <summary>
        /// 기준일시
        /// </summary>
        [JsonProperty("stdDay")]
        public string StdDay { get; set; }

        /// <summary>
        /// 수정일시분초
        /// </summary>
        [JsonProperty("updateDt")]
        public string UpdateDt { get; set; }

        /// <summary>
        /// 확진자 수
        /// </summary>
        [JsonProperty("defCnt")]
        public string DefCnt { get; set; }

        /// <summary>
        /// 격리중 환자 수
        /// </summary>
        [JsonProperty("isolIngCnt")]
        public string IsolIngCnt { get; set; }

        /// <summary>
        /// 해외유입 수
        /// </summary>
        [JsonProperty("overFlowCnt")]
        public string OverFlowCnt { get; set; }

        /// <summary>
        /// 지역발생 수 
        /// </summary>
        [JsonProperty("localOccCnt")]
        public string LocalOccCnt { get; set; }
    }
}
