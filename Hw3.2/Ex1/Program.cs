using System;


namespace Ex1
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
            if (NumO == NumT)
            {
                double c = (NumO + NumT) * 3;
                Console.WriteLine(c);
                Console.ReadKey();
            }
            else
            {
                double b = NumT + NumO;
                Console.WriteLine(b);
                Console.ReadKey();
            }
        

        }
    }
}
