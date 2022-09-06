using System;


namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1N");
            string NumO = Console.ReadLine();
            int one = Convert.ToInt32(NumO);
            if (one%400==0)
            {
                Console.WriteLine(one+ " leap year");
                Console.ReadKey();
            }
            else if (one%100==0)
            {
                Console.WriteLine(one + " no leap year");
                Console.ReadLine();
            }
            else if(one%4==0)
            {
                Console.WriteLine(one + " leap year");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(one + " no leap year");
                Console.ReadLine();
            }
        }
    }
}
