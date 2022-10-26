using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape
{
    class ChoseLocation
    {
        public int X { get; set; }
        public int Y { get; set; }
        DelegateHelp delegateHelp = new DelegateHelp();
        public void Ox()
        {
            for (int i = 0; i <= X; i++)
            {
                delegateHelp.Test3("\n");
            }
        }
        public void Oy()
        {
            for (int b = 0; b <= Y; b++)
            {
                delegateHelp.Test3(" ");
            }   
        }
        public void EnterX_Y()
        {
            delegateHelp.Test3("Enter X  ");
            X = Convert.ToInt32(Console.ReadLine());
            delegateHelp.Test3("Enter Y  ");
            Y = Convert.ToInt32(Console.ReadLine());
        }
    }
}
