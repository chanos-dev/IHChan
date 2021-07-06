using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Model
{
    public class Vaccine
    {
        /// <summary>
        /// All 타이틀
        /// 전체 건수 (누적)
        /// 당일 실적 (신규)
        /// </summary>
        [JsonProperty("tpcd")]
        public string Tpcd { get; set; }

        /// <summary>
        /// Sido 타이틀
        /// </summary>
        [JsonProperty("sidoNm")]
        public string SidoNm { get; set; }

        /// <summary>
        /// 1차 접종 all
        /// 1차 접종 신규 sido
        /// </summary>
        [JsonProperty("firstCnt")]
        public int FirstCnt { get; set; }

        /// <summary>
        /// 1차 접종 토탈 only sido
        /// </summary>
        [JsonProperty("firstTot")]
        public int FirstTot { get; set; }


        /// <summary>
        /// 2차 접종 all
        /// 2차 접종 신규 sido
        /// </summary>
        [JsonProperty("secondCnt")]
        public int SecondCnt { get; set; }

        /// <summary>
        /// 2차 접종 토탈 only sido
        /// </summary>
        [JsonProperty("secondTot")]
        public int SecondTot { get; set; }

    }
}
