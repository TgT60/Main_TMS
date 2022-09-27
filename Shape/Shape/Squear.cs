using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape
{
    class Squear:Figure
    {
        public int Perimetr { get; set; }
        public override void Print()
        {
            
            ChoseTypePrint choseTypePrint = new ChoseTypePrint();
            choseTypePrint.EnterSymble();
            Console.WriteLine("Enter Perimetr");
            Perimetr = int.Parse(Console.ReadLine());
            ChoseLocation choseLocation = new ChoseLocation();
            choseLocation.EnterX_Y();
            choseLocation.Ox();
            for (int i = 0; i < Perimetr; i++)
            {             
                choseLocation.Oy();
                for (int b = 0; b < Perimetr; b++)
                {
                    Console.Write(choseTypePrint.Symble);
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}
