using System;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1N");
            string one = Console.ReadLine();
            int NumO = Convert.ToInt32(one);
            Console.WriteLine("2N");
            string two = Console.ReadLine();
            int NumT = Convert.ToInt32(two);
            if (NumO >= 100 || NumT >= 100)
            {
                Console.WriteLine(true);
                Console.ReadKey();
            }
            else if (NumO<200 || NumT<200)
            {
                Console.WriteLine(false);
                Console.ReadKey();
            }
        }
    }
}
