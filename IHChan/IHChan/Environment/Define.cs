﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Environment
{
    [Flags]
    enum Sido
    {
        합계 = 1,
        서울 = 2,
        부산 = 4,
        대구 = 8,
        인천 = 16,
        광주 = 32,
        대전 = 64,
        울산 = 128,
        세종 = 256,
        경기 = 512,
        강원 = 1024,
        충북 = 2048,
        충남 = 4096,
        전북 = 8182,
        전남 = 16384,
        경북 = 32768,
        경남 = 65536,
        제주 = 131072,
        검역 = 262144,
    }
}