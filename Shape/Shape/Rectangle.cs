using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape
{


    class Rectangle : Figure
    {
        [AtributeColor("Green")]
        public override void Print()
        {
            //void add(string A) => Console.WriteLine(write);
            //add("Emter hight  ");
            var b = Convert.ToInt32(Console.ReadLine());//высота
            Console.Write("Enter width  ");
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
                    Console.Write(choseTypePrint.Symble);
                }
                Console.WriteLine();              
            }
            Console.ReadKey();
        }
    }
}
    
