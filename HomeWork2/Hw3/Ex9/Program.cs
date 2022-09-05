using System;
using System.Collections.Generic;
using System.Text;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1N");
            string one = Console.ReadLine();
            double NumO = Convert.ToDouble(one);
            Console.WriteLine("2N");
            string two = Console.ReadLine();
            double NumT = Convert.ToDouble(two);
            Console.WriteLine("3N");
            string three = Console.ReadLine();
            double NumThree = Convert.ToDouble(three);
            Console.WriteLine("4N");
            string four = Console.ReadLine();
            double NumF = Convert.ToDouble(four);
            Console.WriteLine((NumO+NumT+NumThree+NumF)/4);
            Console.ReadKey();
        }
    }
}
