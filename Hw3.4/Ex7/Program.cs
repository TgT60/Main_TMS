using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your heigth");
            string NumO = Console.ReadLine();
            int one = Convert.ToInt32(NumO);
            if (one >=180)
            {
                Console.WriteLine("You tall");
                Console.ReadKey();
            }
            else if (one <=180 && one >=160)
            {
                Console.WriteLine("You normal heigth" );
                Console.ReadKey();
            }
            else if (one<160)
            {
                Console.WriteLine("You short");
                Console.ReadKey();
            }
        }
    }
}
