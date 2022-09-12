using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pasword = Console.ReadLine();
            for (int i = 1; i < 3; i++)
            {
                if (name == "name" && pasword == "pasword")
                {
                    i = 3;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("try again");
                    name = Console.ReadLine();
                    pasword = Console.ReadLine();

                }

            }

        }
    }
}
