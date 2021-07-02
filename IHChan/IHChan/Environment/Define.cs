using IHChan.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Environment
{
    [Flags]
    public enum Sido
    {
        합계 = 1 << 0,
        [PropertyKRName("서울특별시")]
        서울 = 1 << 1,
        [PropertyKRName("부산광역시")]
        부산 = 1 << 2,
        [PropertyKRName("대구광역시")]
        대구 = 1 << 3,
        [PropertyKRName("인천광역시")]
        인천 = 1 << 4,
        [PropertyKRName("광주광역시")]
        광주 = 1 << 5,
        [PropertyKRName("대전광역시")]
        대전 = 1 << 6,
        [PropertyKRName("울산광역시")]
        울산 = 1 << 7,
        [PropertyKRName("세종특별자치시")]
        세종 = 1 << 8,
        [PropertyKRName("경기도")]
        경기 = 1 << 9,
        [PropertyKRName("강원도")]
        강원 = 1 << 10,
        [PropertyKRName("충청북도")]
        충북 = 1 << 11,
        [PropertyKRName("충청남도")]
        충남 = 1 << 12,
        [PropertyKRName("전라북도")]
        전북 = 1 << 13,
        [PropertyKRName("전라남도")]
        전남 = 1 << 14,
        [PropertyKRName("경상북도")]
        경북 = 1 << 15,
        [PropertyKRName("경상남도")]
        경남 = 1 << 16,
        [PropertyKRName("제주특별자치도")]
        제주 = 1 << 17,
        검역 = 1 << 18,
    }

    public enum CovidType
    {
        [PropertyKRName("확진자")]
        DefCnt,
        [PropertyKRName("격리해제")]
        IsolClear,
        [PropertyKRName("사망자")]
        Death,
        [PropertyKRName("격리 중")]
        IsolIng,
        [PropertyKRName("발생률")]
        Rate,
    }

    [Flags]
    public enum VaccineType
    {
        [PropertyKRName("1차 접종")]
        First = 1,
        [PropertyKRName("2차 접종")]
        Second = 2,

        [PropertyKRName("전국")]
        All = 4,

        Sido = 8,
    }
}
