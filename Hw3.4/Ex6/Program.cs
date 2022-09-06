using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)    
        {
            Console.WriteLine("1N");
            string NumO = Console.ReadLine();
            int one = Convert.ToInt32(NumO);
            int n;
            if (one >0)
            {
                Console.WriteLine(n=1);
                Console.ReadKey();
            }
            else if (one<0)
            {
                Console.WriteLine(n=-1);
                Console.ReadKey();
            }
            else if (one==0)
            {
                Console.WriteLine(n=0);
                Console.ReadKey();
            }
        }
    }
}
