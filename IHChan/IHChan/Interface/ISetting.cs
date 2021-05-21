using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Interface
{
    internal interface ISetting
    {
        void Set();
        MetroStyleManager Manager { get; set; }
    }
}
