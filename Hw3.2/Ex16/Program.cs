using System;

namespace Ex16
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
            if ((NumO >= 20 && NumO <= 50) && (NumT >= 20 && NumT <= 50))
            {
                Console.WriteLine(false);
                Console.ReadKey();
            }
            else
            {

                Console.WriteLine(true);
                Console.ReadKey();
            }    
        }
    }
}
