using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape
{
    class Triangle : Figure
    {
        public int Hight { get; set; }
        public bool Figure { get; set; }
        [AtributeColor("Purple")]
        public override void Print()
        {
            ChoseLocation choseLocation = new ChoseLocation();
            ChoseTypePrint choseTypePrint = new ChoseTypePrint();
            choseTypePrint.EnterSymble();
            Console.Write("Enter Hight   ");
            Hight = int.Parse(Console.ReadLine());
            choseLocation.EnterX_Y();
            choseLocation.Ox();
            for (int i = 0; i < Hight ; i++)
            {
                choseLocation.Oy();
                for (int b = 0; b <= i; b++)
                {
                    Console.Write(choseTypePrint.Symble);
                }
                Console.WriteLine();             
            }
            Console.ReadKey();
            
        }
    }
}
