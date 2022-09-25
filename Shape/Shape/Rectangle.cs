using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape
{


    class Rectangle : Figure
    {
        public override void Print()
        {
            Console.WriteLine("Emter hight");
            int b = Convert.ToInt32(Console.ReadLine());//высота
            Console.WriteLine("Enter width");
            int i = Convert.ToInt32(Console.ReadLine()); // Шерина
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
    
