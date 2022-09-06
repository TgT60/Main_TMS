using System;


namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1N");
            string NumO = Console.ReadLine();
            int one = Convert.ToInt32(NumO);
            if (one>0)
            {
                Console.WriteLine(one+" positive number");
                Console.ReadKey();
            }
            else if (one<0)
            {
                Console.WriteLine(one+" negative number");
                Console.ReadKey();
            }
        }
    }
}
