using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.Attributes
{
    class PropertyKRNameAttribute : Attribute
    {
        public string Name { get; set; }

        public PropertyKRNameAttribute(string name)
        {
            this.Name = name;
        }
    }
}
