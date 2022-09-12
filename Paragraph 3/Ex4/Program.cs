using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imput radius");
            double number = Convert.ToDouble(Console.ReadLine());
            double perimeter = number * 2 * 3.14;
            double area = 3.14 * (number *number);
            Console.WriteLine($"AREA = {area}");
            Console.WriteLine($"Perimeter = {perimeter}");
            Console.ReadLine();
        }
    }
}
