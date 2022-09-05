using System;
using System.Collections.Generic;
using System.Text;

namespace Ex7
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
            Console.WriteLine((NumO+NumT)+"\n"+(NumO - NumT)+ "\n" +(NumO*NumT)+"\n"+(NumO/NumT)+"\n"+(NumO%NumT));
            Console.ReadLine();
        }
    }
}
