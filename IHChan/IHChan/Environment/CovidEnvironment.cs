using IHChan.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Environment
{
    internal class CovidEnvironment
    {
        /// <summary>
        /// 공공데이터 센터 Base URL
        /// </summary>
        internal static string BASE_URL => @"http://openapi.data.go.kr";

        /// <summary>
        /// 질병관리본부 Base URL
        /// </summary>
        internal static string VACCIN_URL => @"https://nip.kdca.go.kr";

        /// <summary>
        /// Response Json Node
        /// </summary>
        internal static string BASE_JSON_TOP_OBJECT => "response/body/items/item";

        internal static string HEADER_JSON_OBJECT => "response/header";

        /// <summary>
        /// 2021-07-02 기준 대한민국 인구 수 5,182만 1,669명
        /// </summary>
        internal static int KOREAN_POPULATION => 51821669;

        #region COVID_URL 
        [CovidLocation(Sido.합계 | Sido.검역)]
        internal const string MAIN_COVID_URL = @"http://ncov.mohw.go.kr/";

        [CovidLocation(Sido.서울)]
        internal const string SEOUL_COVID_URL = @"https://www.seoul.go.kr/coronaV/coronaStatus.do";

        [CovidLocation(Sido.부산)]
        internal const string BUSAN_COVID_URL = @"https://www.busan.go.kr/covid19/Corona19.do";

        [CovidLocation(Sido.대구)]
        internal const string DAEGU_COVID_URL = @"http://covid19.daegu.go.kr/index.html";

        [CovidLocation(Sido.인천)]
        internal const string INCHEON_COVID_URL = @"https://www.incheon.go.kr/index";

        [CovidLocation(Sido.광주)]
        internal const string GWANGJU_COVID_URL = @"https://www.gwangju.go.kr/c19/";

        [CovidLocation(Sido.대전)]
        internal const string DAEJEON_COVID_URL = @"https://www.daejeon.go.kr/corona19/index.do";

        [CovidLocation(Sido.울산)]
        internal const string ULSAN_COVID_URL = @"https://covid19.ulsan.go.kr/index.do";

        [CovidLocation(Sido.세종)]
        internal const string SEJONG_COVID_URL = @"https://www.sejong.go.kr/";

        [CovidLocation(Sido.경기)]
        internal const string GYEONGGI_COVID_URL = @"https://www.gg.go.kr/contents/contents.do?ciIdx=1150&menuId=2909";

        [CovidLocation(Sido.강원)]
        internal const string GANGWON_COVID_URL = @"http://www.provin.gangwon.kr/covid-19.html";

        [CovidLocation(Sido.충북)]
        internal const string CHUNGBUK_COVID_URL = @"https://www.chungbuk.go.kr/intro/index.html";

        [CovidLocation(Sido.충남)]
        internal const string CHUNGNAM_COVID_URL = @"http://www.chungnam.go.kr/coronaStatus.do";

        [CovidLocation(Sido.전북)]
        internal const string JEONBUK_COVID_URL = @"https://www.jeonbuk.go.kr/board/list.jeonbuk?boardId=BBS_0000105&menuCd=DOM_000000110001000000&contentsSid=1219&cpath=";

        [CovidLocation(Sido.전남)]
        internal const string JEONNAM_COVID_URL = @"https://www.jeonnam.go.kr/coronaMainPage.do";

        [CovidLocation(Sido.경북)]
        internal const string GYEONGBUK_COVID_URL = @"https://www.gb.go.kr/Main/open_contents/section/wel/page.do?mnu_uid=5856";

        [CovidLocation(Sido.경남)]
        internal const string GYEONGNAM_COVID_URL = @"http://xn--19-q81ii1knc140d892b.kr/main/main.do";

        [CovidLocation(Sido.제주)]
        internal const string JEJU_COVID_URL = @"https://covid19.jeju.go.kr/";
        #endregion
    }
}
