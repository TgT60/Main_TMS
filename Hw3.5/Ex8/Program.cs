using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string m = Console.ReadLine();
            int n = Convert.ToInt32(m);
            int sum = 0;
            for (int i = 1; i <=n ; i++)
            {
                if (i % 2 == 0)
                {
                    n++;
                }
                else
                {

                    Console.WriteLine(i);
                    Console.ReadKey();
                    sum = sum + i;
                    
                }
                
               
           
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

    }
}
