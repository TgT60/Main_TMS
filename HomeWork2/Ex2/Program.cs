using System;


namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string num_one = Console.ReadLine();
            int a = Convert.ToInt32(num_one);
            Console.WriteLine("Enter second number");
            string num_two = Console.ReadLine();
            int b = Convert.ToInt32(num_two);
            Console.WriteLine("Sum ="+(a + b)) ;
            Console.ReadKey();
        }
    }
}
