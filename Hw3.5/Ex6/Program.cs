using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string m = Console.ReadLine();
            int n = Convert.ToInt32(m);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n+ " X " + i +" = "+ (i*n) );
                Console.ReadLine();
            }
        }
    }
}
