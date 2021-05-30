using MetroFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Environment
{
    internal class ColorSet
    {
        public static Color GetMetroColorToSystemColor(MetroColorStyle color)
        {
            switch (color)
            { 
                case MetroColorStyle.Black:
                    return Color.FromArgb(0, 0, 0);                    
                case MetroColorStyle.White:
                    return Color.FromArgb(255, 255, 255);                    
                case MetroColorStyle.Silver:
                    return Color.FromArgb(85, 85, 85);
                case MetroColorStyle.Blue:
                    return Color.FromArgb(0, 174, 219);
                case MetroColorStyle.Green:
                    return Color.FromArgb(0, 177, 89);
                case MetroColorStyle.Lime:
                    return Color.FromArgb(142, 188, 0);
                case MetroColorStyle.Teal:
                    return Color.FromArgb(0, 170, 173);
                case MetroColorStyle.Orange:
                    return Color.FromArgb(243, 119, 53);
                case MetroColorStyle.Brown:
                    return Color.FromArgb(165, 81, 0);
                case MetroColorStyle.Pink:
                    return Color.FromArgb(231, 113, 189);
                case MetroColorStyle.Magenta:
                    return Color.FromArgb(255, 0, 148);
                case MetroColorStyle.Purple:
                    return Color.FromArgb(124, 65, 153);
                case MetroColorStyle.Red:
                    return Color.FromArgb(209, 17, 65);
                case MetroColorStyle.Yellow:
                    return Color.FromArgb(255, 196, 37);
                default:
                    return Color.FromArgb(0, 174, 219);
            }
        }
    }
}
