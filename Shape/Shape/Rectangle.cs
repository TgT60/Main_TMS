using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape
{
    
    [ColorAtibute(ConsoleColor.Blue)]
    class Rectangle : Figure
    {       
        public override void Print()
        {
            DelegateHelp delegateHelp = new DelegateHelp();  
            Type t = typeof(Rectangle);
            object[] attrs = t.GetCustomAttributes(false);
            foreach (ColorAtibute color in attrs)
            {
                Console.ForegroundColor = color.Color;
            }
            delegateHelp.Test("Enter hight  ");
            var b = Convert.ToInt32(Console.ReadLine()); //высота
            delegateHelp.Test("Enter width  ");
            var i = Convert.ToInt32(Console.ReadLine()); // Шерина
            ChoseTypePrint choseTypePrint = new ChoseTypePrint();
            choseTypePrint.EnterSymble();
            ChoseLocation choseLocation = new ChoseLocation();
            choseLocation.EnterX_Y();
            choseLocation.Ox();
            for (int c= 0; c < b; c++)
            {
                choseLocation.Oy();
                for (int g = 0;g < i; g++)
                {
                    delegateHelp.Test3(choseTypePrint.Symble);
                }
                delegateHelp.Test2();
            }
            delegateHelp.Test4();
           
        }
    }
}
    
