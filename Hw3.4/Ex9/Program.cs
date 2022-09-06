using System;
using System.Collections.Generic;
using System.Text;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the value for X coordinate ");
            string NumO = Console.ReadLine();
            int one = Convert.ToInt32(NumO);
            Console.WriteLine("Input the value for Y coordinate ");
            string NumT = Console.ReadLine();
            int two = Convert.ToInt32(NumT);
            if (one > 0 && two > 0)
            {
                Console.WriteLine("The coordinate point" + "(" + (one) + "," + (two) + ")" + "lies in the First quadrant.");
                Console.ReadKey();
            }
            else if (one < 0 && two > 0)
            {
                Console.WriteLine("The coordinate point" + "(" + (one) + "," + (two) + ")" + "lies in the Second quadrant.");
                Console.ReadKey();
            }
            else if(one<0 && two<0)
            {
                Console.WriteLine("The coordinate point" + "(" + (one) + "," + (two) + ")" + "lies in the Three quadrant.");
                Console.ReadKey();
            }
            else if(one>0 && two<0) 
            {
                Console.WriteLine("The coordinate point" + "(" + (one) + "," + (two) + ")" + "lies in the Four quadrant.");
                Console.ReadKey();
            }
        }
    }
}
