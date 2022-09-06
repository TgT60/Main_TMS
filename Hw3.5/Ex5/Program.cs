using System;


namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string m = Console.ReadLine();
            int n = Convert.ToInt32(m);
            for (int i = 0; i <=n; i++)
            {
                Console.WriteLine("Number is : "+ i + " and cube of the " + i + " is " + (i*i*i));
                Console.ReadKey();
            }
        }
    }
}
