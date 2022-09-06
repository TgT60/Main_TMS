using System;


namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1N");
            string NumO = Console.ReadLine();
            int one = Convert.ToInt32(NumO);
            Console.WriteLine("2N");
            string NumT = Console.ReadLine();
            int two = Convert.ToInt32(NumT);
            if (two==one)
            {
                Console.WriteLine(one+"="+two);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(one+ "!="+two);
                Console.ReadKey();
            }


        }
    }
}
