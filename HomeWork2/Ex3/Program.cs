using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string num_one = Console.ReadLine();
            double  a = Convert.ToDouble(num_one);
            Console.WriteLine("Enter second number");
            string num_two = Console.ReadLine();
            double b = Convert.ToDouble(num_two);
            Console.WriteLine("Demult " + (a / b));
            Console.ReadKey();
        }
    }
}
