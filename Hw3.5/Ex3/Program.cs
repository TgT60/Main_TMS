using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            string m = Console.ReadLine();
            int n = Convert.ToInt32(m);
            int sum = 0 ;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                Console.ReadKey();
                sum = sum + i;
                if(i == n)
                {
                    Console.WriteLine(sum);
                    Console.ReadKey();
                }
            }

        }
    }
}
