using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string c = Console.ReadLine();
            Console.WriteLine("Enter Hight");
            int hight = Convert.ToInt32 (Console.ReadLine());
            for (int b = 0; b < hight; b++)
            {
                for (int i = hight; i > b; i--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        
            Console.ReadKey();
        }
    }
}
