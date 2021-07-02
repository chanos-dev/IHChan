using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Poc
{
    public partial class Form1 : Form
    {
        GeoMap geoMap1 = new GeoMap();

        public Form1()
        {
            InitializeComponent();

            //InitializeMap();
            InitializeKoreaMap();
        }

        private void InitializeKoreaMap()
        {
            var values = new Dictionary<string, double>();

            //values["4194"] = 1290000; 


            geoMap1.HeatMap = values;

            geoMap1.Source = "World/Korea.xml";
            this.Controls.Add(geoMap1);
            geoMap1.Dock = DockStyle.Fill;
        }

        private void InitializeMap()
        { 
            var r = new Random(); 

            var values = new Dictionary<string, double>();

            values["MX"] = 1;
            values["CA"] = 1290000;
            values["US"] = 33479348;
            values["IN"] = 22940516;
            values["CN"] = r.Next(0, 100);
            values["JP"] = r.Next(0, 100);
            values["BR"] = 15184790;
            values["DE"] = r.Next(0, 100);
            values["FR"] = r.Next(0, 100);
            values["GB"] = r.Next(0, 100);
            values["KR"] = 127772;
            values["RU"] = 4888727;

            geoMap1.LandClick += GeoMap1_LandClick;

            //geoMap1.BackColor = System.Drawing.Color.Purple;

            geoMap1.HeatMap = values; 
            geoMap1.Source = "World/World.xml";            

            // move, zoom in and zoom out
            geoMap1.EnableZoomingAndPanning = true;

            // show a value of heatmap on the Geomap.
            geoMap1.Hoverable = true; 

            geoMap1.DefaultLandFill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 242, 242));

            this.Controls.Add(geoMap1);            
            geoMap1.Dock = DockStyle.Fill;

            geoMap1.Base.MouseDoubleClick += Base_MouseDoubleClick;

            //geoMap1.Base.LandStroke

            //geoMap1.LandStroke = brush;

            geoMap1.Base.LandStroke = new System.Windows.Media.SolidColorBrush(Colors.Gray);                       

            geoMap1.GradientStopCollection = new GradientStopCollection()
            { 
                new GradientStop(System.Windows.Media.Color.FromRgb(250,233,233), 0.00),
                new GradientStop(System.Windows.Media.Color.FromRgb(234,207,207), 0.25),
                new GradientStop(System.Windows.Media.Color.FromRgb(191,132,132), 0.55), 
                new GradientStop(System.Windows.Media.Color.FromRgb(158,76,76), 0.75),
                new GradientStop(System.Windows.Media.Color.FromRgb(113,0,0), 1.00),
            };

            //var lang = new Dictionary<string, string>();
            //lang["KR"] = "Korea";
            //geoMap1.LanguagePack = lang; 
        } 

        private void Base_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void GeoMap1_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            var a = arg1;
                       
        }
    }
}
