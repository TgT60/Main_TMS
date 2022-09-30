using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape
{
    class ChoseTypePrint
    {
        public string Symble { get; set; }
        public void EnterSymble()
        {
            Console.Write($"Chose sumble   ");
            Symble = Console.ReadLine();
        }
    }
}
