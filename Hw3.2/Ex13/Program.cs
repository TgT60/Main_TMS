using System;

namespace Ex13
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
            if ((NumO < 0 || NumO > 100) && (NumT< 0 || NumT > 100))
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
