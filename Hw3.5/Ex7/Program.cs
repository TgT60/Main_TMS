using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string m = Console.ReadLine();
            int n = Convert.ToInt32(m);
            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j <=n; j++)
                {
                    if (j<=n-1)
                    {
                        Console.Write(i + " * " + j + " = " + ( i* j));
                        Console.ReadKey();
                    }
                    else
                        Console.Write(i + " * " + j + " = " + (i * j));


                }
                Console.WriteLine("\n");
            }


       

            
        }
    }
}
