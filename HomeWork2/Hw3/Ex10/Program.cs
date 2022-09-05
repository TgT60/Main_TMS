using System;
using System.Collections.Generic;
using System.Text;

namespace Ex10
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
            Console.WriteLine((NumO+NumT)*NumThree+" and "+(NumO*NumT+NumT*NumThree));
            Console.ReadKey();
        }
    }
}
