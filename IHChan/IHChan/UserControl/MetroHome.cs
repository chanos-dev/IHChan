using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using IHChan.Environment;
using IHChan.Model;
using IHChan.APIs;
using IHChan.Extentions;
using IHChan.Common;

namespace IHChan.UserControl
{
    internal partial class MetroHome : BaseMetroUserControl
    {
        private string TodayDate => $"{DateTime.Now:d}";

        private Dictionary<VaccineType, List<Vaccine>> Vaccines { get; set; }

        private InformationOfCovidSidoJson HomeCountryCovid { get; set; }

        private InformationOfCovidOverseasJson OverseasCovid { get; set; }

        private BackgroundWorker Worker { get; set; }

        public MetroHome() : base()
        {
            InitializeComponent();
            InitializeBaseControl(this); 
             
            InitializeControl();
            InitializeDashboard();
        }  

        private void InitializeDashboard()
        {
            db_homedef.Type = CovidType.DefCnt;
            db_homeisolclear.Type = CovidType.IsolClear;
            db_homedeath.Type = CovidType.Death;
            db_homeisoling.Type = CovidType.IsolIng;

            db_overseadef.Type = CovidType.DefCnt;
            db_overseaisolclear.Type = CovidType.IsolClear;
            db_overseadeath.Type = CovidType.Death;
            db_overseaisoling.Type = CovidType.IsolIng;

            dbv_first.Type = VaccineType.First | VaccineType.All;
            dbv_second.Type = VaccineType.Second | VaccineType.All;

            // need to add sido name
            dbv_firstsido.Type = VaccineType.First;
            dbv_secondsido.Type = VaccineType.Second;

            mcb_location.Items.AddRange(Enum.GetNames(typeof(Sido)));
            // delete sido.합계, sido.검역
            mcb_location.Items.RemoveAt(0);
            mcb_location.Items.RemoveAt(mcb_location.Items.Count-1); 
        }

        private void InitializeControl()
        {
            /// control
            mlb_date.Text = $"Today : {TodayDate}";
            mlb_vaccine.Text = $"국내현황 {TodayDate}. 00:00 집계 기준";

            Vaccines = new Dictionary<VaccineType, List<Vaccine>>();
            OverseasCovid = new InformationOfCovidOverseasJson();

            Worker = new BackgroundWorker();
            Worker.DoWork += Worker_DoWork;
            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            Worker.RunWorkerAsync();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // vaccine
            Vaccines[VaccineType.All] = CovidController.Instance.GetVaccine(VaccineType.All);
            Vaccines[VaccineType.Sido] = CovidController.Instance.GetVaccine(VaccineType.Sido);

            // covid
            HomeCountryCovid = CovidController.Instance.GetSidoCovidState(TodayDate, TodayDate)?.Where(sido => sido.Gubun == $"{Sido.합계}").FirstOrDefault();
            var overseas = CovidController.Instance.GetOverseasCovidState(TodayDate, TodayDate).Where(sea => $"{sea.CreateDt:d}" == TodayDate);

            OverseasCovid.NatDefCnt = overseas.Sum(sea => sea.NatDefCnt);            
            OverseasCovid.NatDeathCnt = overseas.Sum(sea => sea.NatDeathCnt);
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            mcb_location.SelectedIndex = 0;

            SetVaccineAll();
            SetVaccineSido();

            SetHomeCountry();
        
        }

        private void SetVaccineAll()
        { 
            // total dashboard
            var total = Vaccines[VaccineType.All].Where(va => va.Tpcd.Contains("전체건수")).FirstOrDefault();
            var day = Vaccines[VaccineType.All].Where(va => va.Tpcd.Contains("당일실적")).FirstOrDefault();

            dbv_first.FirstValue = $"{total.FirstCnt:#,##0} 명";
            dbv_first.SecondValue = $"{day.FirstCnt:#,##0} 명";
            dbv_first.Rate = GetVaccineRate($"{total.FirstCnt}", CovidEnvironment.KOREAN_POPULATION);

            dbv_second.FirstValue = $"{total.SecondCnt:#,##0} 명";
            dbv_second.SecondValue = $"{day.SecondCnt:#,##0} 명";
            dbv_second.Rate = GetVaccineRate($"{total.SecondCnt}", CovidEnvironment.KOREAN_POPULATION);
        }

        private void SetVaccineSido()
        {  
            // sido dashboard
            var sido = EnumHelper.GetSidoKRName(mcb_location.Text);

            var sidoTotal = Vaccines[VaccineType.Sido].Where(va => va.SidoNm == sido).FirstOrDefault();
            var sidoDay = Vaccines[VaccineType.Sido].Where(va => va.SidoNm == sido).FirstOrDefault();

            dbv_firstsido.FirstValue = $"{sidoTotal.FirstTot:#,##0} 명";
            dbv_firstsido.SecondValue = $"{sidoDay.FirstCnt:#,##0} 명";
            dbv_firstsido.Rate = GetVaccineRate($"{sidoTotal.FirstTot}", CovidEnvironment.KOREAN_POPULATION);

            dbv_secondsido.FirstValue = $"{sidoTotal.SecondTot:#,##0} 명";
            dbv_secondsido.SecondValue = $"{sidoDay.SecondCnt:#,##0} 명";
            dbv_secondsido.Rate = GetVaccineRate($"{sidoTotal.SecondTot}", CovidEnvironment.KOREAN_POPULATION);
        }

        private void SetHomeCountry()
        {
            if (HomeCountryCovid is null)
                return;

            db_homedef.Value = $"{HomeCountryCovid.DefCnt.AddComma()} 명";
            db_homeisolclear.Value = $"{HomeCountryCovid.IsolClearCnt.AddComma()} 명";
            db_homedeath.Value = $"{HomeCountryCovid.DeathCnt.AddComma()} 명";
            db_homeisoling.Value = $"{HomeCountryCovid.IsolIngCnt.AddComma()} 명";


            db_overseadef.Value = $"{OverseasCovid.NatDefCnt.ToString().AddComma()} 명";
            db_overseadeath.Value = $"{OverseasCovid.NatDeathCnt.ToString().AddComma()} 명";
        }

        private string GetVaccineRate(string numerator, string denominator) => $"{Math.Round((numerator.ConvertToDouble() / denominator.ConvertToDouble()) * 100, 1)}%";

        private void mcb_location_SelectedIndexChanged(object sender, EventArgs e) => SetVaccineSido();
    }
}
