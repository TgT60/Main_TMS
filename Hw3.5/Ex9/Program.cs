using System;


namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string m = Console.ReadLine();
            int n = Convert.ToInt32(m);
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
                Console.ReadKey();

            }
        }
    }
}
