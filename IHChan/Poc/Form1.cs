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

namespace Poc
{
    public partial class Form1 : Form
    {
        GeoMap geoMap1 = new GeoMap();

        public Form1()
        {
            InitializeComponent();

            InitializeMap();
        }

        private void InitializeMap()
        { 
            var r = new Random(); 

            var values = new Dictionary<string, double>();

            values["MX"] = 1;
            values["CA"] = 10;
            values["US"] = 100;
            values["IN"] = r.Next(0, 100);
            values["CN"] = r.Next(0, 100);
            values["JP"] = r.Next(0, 100);
            values["BR"] = r.Next(0, 100);
            values["DE"] = r.Next(0, 100);
            values["FR"] = r.Next(0, 100);
            values["GB"] = r.Next(0, 100);
            values["KR"] = 10;

            geoMap1.LandClick += GeoMap1_LandClick;            
            geoMap1.BackColor = Color.Gray;  

            geoMap1.HeatMap = values; 
            geoMap1.Source = "World/World.xml";            

            // move, zoom in and zoom out
            geoMap1.EnableZoomingAndPanning = true;

            // show a value of heatmap on the Geomap.
            geoMap1.Hoverable = true;

            var brush = new System.Windows.Media.SolidColorBrush();

            brush.Color = System.Windows.Media.Color.FromRgb(62, 62, 66);

            geoMap1.DefaultLandFill = brush;            

            this.Controls.Add(geoMap1);            
            geoMap1.Dock = DockStyle.Fill;

            geoMap1.Base.MouseDoubleClick += Base_MouseDoubleClick;

            //geoMap1.Base.LandStroke

            //geoMap1.LandStroke = brush;

            geoMap1.Base.LandStroke = brush;

            

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
