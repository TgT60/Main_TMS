using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)  
        {
            int sum = 0;
            for (int i = 1 ; i <= 10; i++)     
            {
                Console.Write(i);
                Console.ReadKey();
                sum = sum + i;
                if (i == 10)
                {
                    Console.WriteLine("\n"+sum);
                    Console.ReadKey();
                }
            }

        }
    }
}
