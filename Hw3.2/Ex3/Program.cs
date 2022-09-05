using System;


namespace Ex3
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
            if (NumT == 30 || NumO == 30 || (NumO + NumT) == 30)
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
