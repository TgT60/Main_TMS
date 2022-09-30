using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape
{
    class AtributeColor : Attribute
    {
        public string Color { get; set; }
        public AtributeColor(string color)
        {
            Color = color;
        }

      
    }
}
