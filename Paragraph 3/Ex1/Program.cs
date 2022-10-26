using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string g;
            g = a;
            a = c;
            c = g;
            Console.WriteLine($"{a} {b} {c}");

            Console.ReadKey();

        }
    }
}
