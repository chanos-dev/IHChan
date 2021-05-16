using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Model
{
    /// <summary>
    /// 공공데이터활용지원센터_보건복지부 코로나19 감염 현황 Model
    /// </summary>
    public class InformationOfCovidHomeCountryJson
    {
        /// <summary>
        /// 게시글번호(감염현황 고유값)
        /// </summary>
        [JsonProperty("seq")]
        public string Seq { get; set; }

        /// <summary>
        /// 기준일
        /// </summary>
        [JsonProperty("stateDt")]
        public string StateDt { get; set; }

        /// <summary>
        /// 기준시간
        /// </summary>
        [JsonProperty("stateTime")]
        public string StateTime { get; set; }

        /// <summary>
        /// 확진자 수
        /// </summary>
        [JsonProperty("decideCnt")]
        public string DecideCnt { get; set; }

        /// <summary>
        /// 격리해제 수
        /// </summary>
        [JsonProperty("clearCnt")]
        public string ClearCnt { get; set; }        

        /// <summary>
        /// 검사진행 수
        /// </summary>
        [JsonProperty("examCnt")]
        public string ExamCnt { get; set; }

        /// <summary>
        /// 사망자 수
        /// </summary>
        [JsonProperty("deathCnt")]
        public string DeathCnt { get; set; }

        /// <summary>
        /// 치료중 환자 수
        /// </summary>
        [JsonProperty("careCnt")]
        public string CareCnt { get; set; }

        /// <summary>
        /// 결과 음성 수
        /// </summary>
        [JsonProperty("resutlNegCnt")]
        public string ResutlNegCnt { get; set; }
         
        /// <summary>
        /// 누적 검사 수
        /// </summary>
        [JsonProperty("accExamCnt")]
        public string AccExamCnt { get; set; }

        /// <summary>
        /// 누적 검사 완료 수
        /// </summary>
        [JsonProperty("accExamCompCnt")]
        public string AccExamCompCnt { get; set; }

        /// <summary>
        /// 누적 환진률
        /// </summary>
        [JsonProperty("accDefRate")]
        public string AccDefRate { get; set; }

        /// <summary>
        /// 등록일시분초
        /// </summary>
        [JsonProperty("createDt")]
        public string CreateDt { get; set; }              

        /// <summary>
        /// 수정일시분초
        /// </summary>
        [JsonProperty("updateDt")]
        public string UpdateDt { get; set; }
    }
}
