using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter anouther number");
            int b = Convert.ToInt32(Console.ReadLine());
            Step(a,b);
            Console.ReadKey();
        }
        static void Step(int a,int b)
        {
            double c = Math.Pow(a, b);
            Console.WriteLine(c);
            


        }

    }  
}
