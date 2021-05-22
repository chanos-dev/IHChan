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
using LiveCharts.WinForms;
using System.Windows.Media;
using IHChan.APIs;
using System.Threading;
using IHChan.Model;
using IHChan.Converter;
using System.IO;

namespace IHChan.UserControl
{
    /// <summary>
    /// 21.05.22 Issuse : MetroGrid Style이 적용이 안됨
    /// </summary>
    internal partial class MetroOverseas : BaseMetroUserControl
    {
        private readonly string WorldPath = @"World/World.xml";
        private GeoMap GeoMap { get; set; }

        public MetroOverseas()
        {
            InitializeComponent();
            InitializeControl();
            InitializeBaseControl(this);            
            InitializeMap();
        }

        private void InitializeControl()
        {
            DirectControls = new List<IMetroControl>();

            DirectControls.Add(metroGrid1);
        }

        private void InitializeMap()
        {
            GeoMap = new GeoMap();

            GeoMap.Source = WorldPath;

            // move, zoom in and zoom out
            GeoMap.EnableZoomingAndPanning = true;

            // show a value of heatmap on the Geomap.
            GeoMap.Hoverable = true; 

            GeoMap.DefaultLandFill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 242, 242));

            GeoMap.Base.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(128, 128, 128));

            metroPanel3.Controls.Add(GeoMap);
            GeoMap.Dock = DockStyle.Fill;            

            GeoMap.LandStroke = new SolidColorBrush(Colors.Black);

            GeoMap.GradientStopCollection = new GradientStopCollection()
            {
                new GradientStop(System.Windows.Media.Color.FromRgb(250,233,233), 0.00),
                new GradientStop(System.Windows.Media.Color.FromRgb(234,207,207), 0.25),
                new GradientStop(System.Windows.Media.Color.FromRgb(191,132,132), 0.55),
                new GradientStop(System.Windows.Media.Color.FromRgb(158,76,76), 0.75),
                new GradientStop(System.Windows.Media.Color.FromRgb(113,0,0), 1.00),
            };

            var overseas = CovidController.Instance.GetOverseasCovidState("2021-05-21",  "2021-05-21");

            // TEST Values
            var values = new Dictionary<string, double>();

            values["MX"] = 1;
            values["CA"] = 1290000;
            values["US"] = 33479348;
            values["IN"] = 22940516;
            values["BR"] = 15184790;
            values["KR"] = 127772;
            values["RU"] = 4888727;

            GeoMap.HeatMap = values;
        } 

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is List<InformationOfCovidOverseasJson> overseas)
            {
                
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = CovidController.Instance.GetOverseasCovidState("2021-05-21", "2021-05-21");
        } 
    } 
}
