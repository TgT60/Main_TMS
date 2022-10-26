using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape
{
    class Text : IPrintable
    {
        public void EnterText()
        {
            DelegateHelp delegateHelp = new DelegateHelp();
            ChoseLocation choseLocation = new ChoseLocation();
            choseLocation.EnterX_Y();
            choseLocation.Ox();
            choseLocation.Oy();
            string a = Console.ReadLine();
            delegateHelp.Test(a);
        }
    }
}
