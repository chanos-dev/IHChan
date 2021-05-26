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
using System.Drawing.Drawing2D;
using IHChan.Options;
using MetroFramework;

namespace IHChan.UserControl
{
    internal partial class CircleGraph : MetroUserControl
    {
        #region Fields
        private Color _backColor = Color.Gray;
        private Color _foreColor = Color.Green;
        private double _inCircleRate = 0.5;
        //private bool _halfCircle = true;
        private int _value = 0;
        private int _maxValue = 100;

        private Color _textColor = Color.Black;
        private string _text = string.Empty;
        private StringAlignment _alignment = StringAlignment.Near;
        #endregion

        #region Properties
        [Category("CircleGraph Properties")]
        public Color BackCircleColor
        {
            get => _backColor;
            set
            {
                _backColor = value;
                this.Refresh();
            }
        }

        [Category("CircleGraph Properties")]
        public Color ForeCircleColor
        {
            get => _foreColor;
            set
            {
                _foreColor = value;
                this.Refresh();
            }
        }

        [Category("CircleGraph Properties")]
        public double InCircleRate
        {
            get => _inCircleRate;
            set
            {
                if (value < 0.1 || value > 0.9)
                    throw new Exception("The rate range from 0.1 to 0.9.");

                _inCircleRate = value;
                this.Refresh();
            }
        }

        //[Category("CircleGraph Properties")]
        //public bool HalfCircle
        //{
        //    get => _halfCircle;
        //    set
        //    {
        //        _halfCircle = value;
        //        this.Refresh();
        //    }
        //}

        [Category("CircleGraph Properties")]
        public int Value
        {
            get => _value;
            set
            {
                if (value < 0 || value > MaxValue)
                    throw new Exception("The Value Property has to be low than MaxValue or high than zero.");

                _value = value;
                this.Refresh();
            }
        }

        [Category("CircleGraph Properties")]
        public int MaxValue
        {
            get => _maxValue;
            set
            {
                if (value < Value)
                    throw new Exception("The MaxValue Property has to be high than the Value.");

                _maxValue = value;
                this.Refresh();
            }
        }

        [Category("CircleGraph Properties")]
        public string CirCleText
        {
            get => _text;
            set
            {
                _text = value;
                this.Refresh();
            }
        }

        [Category("CircleGraph Properties")]
        public StringAlignment Alignment
        {
            get => _alignment;
            set
            {
                _alignment = value;
                this.Refresh();
            }
        }

        [Category("CircleGraph Properties")]
        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                this.Refresh();
            }
        }

        #endregion

        #region Constructor
        public CircleGraph()
        {
            InitializeComponent(); 
        }
        #endregion

        #region Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var mainCir = new Rectangle(0, 0, this.Width, this.Height);            

            int inCirWidth = (int)Math.Round(this.Width * InCircleRate);
            int inCirHeight = (int)Math.Round(this.Width * InCircleRate);
            var inX = (int)Math.Round((this.Width / 2.0) - (inCirWidth / 2.0));
            //var inY = (int)Math.Round((this.Height / 2.0) - (inCirHeight / 2.0)) + (HalfCircle ? 1 : 0);
            var inY = (int)Math.Round((this.Height / 2.0) - (inCirHeight / 2.0)) + 1;

            var inCir = new Rectangle(inX, inY, inCirWidth, inCirHeight);            

            //e.Graphics.FillPie(new SolidBrush(BackCircleColor), mainCir, 180, HalfCircle ? 180 : 360);
            e.Graphics.FillPie(new SolidBrush(BackCircleColor), mainCir, 180, 180);

            if (Value > 0)
            { 
                e.Graphics.FillPie(new SolidBrush(ForeCircleColor), mainCir, 180, (int)Math.Round((180.0 / MaxValue) * Value));
            }

            switch(base.Theme)
            {
                case MetroThemeStyle.Dark:
                    //e.Graphics.FillPie(new SolidBrush(Color.FromArgb(17, 17, 17)), inCir, 180, HalfCircle ? 180 : 360);
                    e.Graphics.FillPie(new SolidBrush(Color.FromArgb(17, 17, 17)), inCir, 180, 180);
                    break;
                case MetroThemeStyle.Default:
                case MetroThemeStyle.Light:
                    //e.Graphics.FillPie(new SolidBrush(Color.FromArgb(255, 255, 255)), inCir, 180, HalfCircle ? 180 : 360);
                    e.Graphics.FillPie(new SolidBrush(Color.FromArgb(255, 255, 255)), inCir, 180, 180);
                    break;
            }

            // Draw Text
            var textRect = new Rectangle(1, (this.Height / 2) + 10, this.Width, this.Height/2);

            var format = new StringFormat();
            format.Alignment = Alignment;

            e.Graphics.DrawString(this.CirCleText, this.Font, new SolidBrush(TextColor), textRect, format);
        }
        #endregion
    }
}
