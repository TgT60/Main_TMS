using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1N");
            string NumO = Console.ReadLine();
            int one = Convert.ToInt32(NumO);
            if (one >=18 )
            {
                Console.WriteLine(one+" You can voice ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(one + " You can't voice ");
                Console.ReadKey();
            }
        }
    }
}
