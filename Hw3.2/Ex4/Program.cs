using System;


namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1N");
            string one = Console.ReadLine();
            double NumO = Convert.ToDouble(one);
            if (NumO >= 90 && NumO <= 110  )
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
