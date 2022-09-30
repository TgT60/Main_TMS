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

        public void Ox()
        {
            for (int i = 0; i <= X; i++)
            {
                Console.Write("\n");
            }
        }
        public void Oy()
        {
            for (int b = 0; b <= Y; b++)
            {
                Console.Write(" ");
            }   
        }
        public void EnterX_Y()
        {
            Console.Write("Enter X  ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y  ");
            Y = Convert.ToInt32(Console.ReadLine());
        }
    }
}
