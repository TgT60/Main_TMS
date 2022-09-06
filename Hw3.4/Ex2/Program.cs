using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1N");
            string NumO = Console.ReadLine();
            int one = Convert.ToInt32(NumO);
            if (one%2==0)
            {
                Console.WriteLine(one +" = even");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(one+ " = odd");
                Console.ReadKey();
            }
        }
    }
}
