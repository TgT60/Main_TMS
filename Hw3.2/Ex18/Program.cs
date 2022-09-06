using System;

namespace Ex18
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
            if (NumO > NumT && NumO > NumThree)
            {
                Console.WriteLine(NumO);
                Console.ReadKey();
            }
            else if (NumT > NumO && NumT > NumThree)
            {
                Console.WriteLine(NumT);
                Console.ReadKey();
            }
            else if (NumThree > NumO && NumThree > NumT)
            {

                Console.WriteLine(NumT);
                Console.ReadKey();
            }
            else if (NumO == NumT && NumO== NumThree && NumT== NumThree)
            {

                Console.WriteLine(NumT);
                Console.ReadKey();
            }
        }
    }
}
