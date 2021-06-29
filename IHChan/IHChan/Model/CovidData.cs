using IHChan.Environment;
using IHChan.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Model
{
    internal enum Type
    {
        Current,
        Previous,
    }

    internal class CovidContent : IFormattable
    {
        public double Rate { get; set; }

        public CovidData DefCnt;

        public CovidData DeathCnt;

        public CovidData IsolIngCnt;

        public CovidData IsolClearCnt;

        public CovidContent()
        {
            DefCnt = new CovidData();
        }

        public void InitializeData(InformationOfCovidSidoJson sido, Type type)
        {
            Rate = sido.QurRate.ConvertToDouble();

            if (type == Type.Current)
            {
                DefCnt.Value = sido.DefCnt.ConvertToInt();
                DeathCnt.Value = sido.DeathCnt.ConvertToInt();
                IsolIngCnt.Value = sido.IsolIngCnt.ConvertToInt();
                IsolClearCnt.Value = sido.IsolClearCnt.ConvertToInt();
            }
            else
            {
                DefCnt.PrevValue = sido.DefCnt.ConvertToInt();
                DeathCnt.PrevValue = sido.DeathCnt.ConvertToInt();
                IsolIngCnt.PrevValue = sido.IsolIngCnt.ConvertToInt();
                IsolClearCnt.PrevValue = sido.IsolClearCnt.ConvertToInt();
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
                return string.Empty;

            switch (format)
            {
                case CovidDataFormat.DEFCNT_FORMAT:
                    return $"{DefCnt.Value:#,##0}명 +({DefCnt.DiffValue}명)";
                case CovidDataFormat.DEATHCNT_FORMAT:
                    return $"{DeathCnt.Value:#,##0}명 +({DeathCnt.DiffValue}명)";
                case CovidDataFormat.ISOLINGCNT_FORMAT:
                    return $"{IsolIngCnt.Value:#,##0}명 +({IsolIngCnt.DiffValue}명)";
                case CovidDataFormat.ISOLCLEARCNT_FORMAT:
                    return $"{IsolClearCnt.Value:#,##0}명 +({IsolClearCnt.DiffValue}명)";
                case CovidDataFormat.RATE_FORMAT:
                    return $"{Rate}%";
                default:
                    return string.Empty;
            }
        }

        public override string ToString() => this.ToString(string.Empty, null);
    }

    internal struct CovidData
    {
        public int Value;
        public int PrevValue;

        public int DiffValue
        {
            get
            {
                if ((Value & PrevValue) == 0)
                    return 0;

                return Value - PrevValue;
            }
        }
    }
}
