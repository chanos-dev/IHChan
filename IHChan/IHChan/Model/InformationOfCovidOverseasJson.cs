using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Model
{
    /// <summary>
    /// 공공데이터활용지원센터_보건복지부 코로나19해외발생 현황 Model
    /// </summary>
    public class InformationOfCovidOverseasJson
    {
        /// <summary>
        /// 게시글번호(국외발생현황 고유값)
        /// </summary>
        [JsonProperty("seq")]
        public string Seq { get; set; }

        /// <summary>
        /// 기준일시
        /// </summary>
        [JsonProperty("stdDay")]
        public string StdDay { get; set; }

        /// <summary>
        /// 지역명
        /// </summary>
        [JsonProperty("areaNm")]
        public string AreaNm { get; set; }

        /// <summary>
        /// 지역명(영문)
        /// </summary>
        [JsonProperty("areaNmEn")]
        public string AreaNmEn { get; set; }

        /// <summary>
        /// 지역명(중문)
        /// </summary>
        [JsonProperty("areaNmCn")]
        public string AreaNmCn { get; set; }

        /// <summary>
        /// 국가명
        /// </summary>
        [JsonProperty("nationNm")]
        public string NationNm { get; set; }

        /// <summary>
        /// 국가명(영문)
        /// </summary>
        [JsonProperty("nationNmEn")]
        public string NationNmEn { get; set; }

        /// <summary>
        /// 국가명(중문)
        /// </summary>
        [JsonProperty("nationNmCn")]
        public string NationNmCn { get; set; }

        /// <summary>
        /// 국가별 확진자 수
        /// </summary>
        [JsonProperty("natDefCnt")]
        public double NatDefCnt { get; set; }

        /// <summary>
        /// 국가별 사망자 수
        /// </summary>
        [JsonProperty("natDeathCnt")]
        public string NatDeathCnt { get; set; }

        /// <summary>
        /// 확진률 대비 사망률
        /// </summary>
        [JsonProperty("natDeathRate")]
        public string NatDeathRate { get; set; }

        /// <summary>
        /// 등록일시분초
        /// </summary>
        [JsonProperty("createDt")]
        public DateTime CreateDt { get; set; }

        /// <summary>
        /// 수정일시분초
        /// </summary>
        [JsonProperty("updateDt")]
        public string UpdateDt { get; set; }
    }
}
