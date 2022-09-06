using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter anouther number");
            int b = Convert.ToInt32(Console.ReadLine());
            Sum(a, b);
        }
        static void Sum(int a,int b)
        {

            int sum = a + b;
            Console.WriteLine("The sum of two numbers is "+sum);
            Console.ReadKey();
        }
        
       
    }
}
