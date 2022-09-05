using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1N");
            string one = Console.ReadLine();
            double NumO = Convert.ToDouble(one);
            if (NumO%3==0 || NumO%7==0)
            {
                Console.WriteLine(true);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(false);
                Console.ReadKey();
            }
        }

    }
}
