using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1N");
            string NumO = Console.ReadLine();
            int one = Convert.ToInt32(NumO);
            Console.WriteLine("2N");
            string NumT = Console.ReadLine();
            int two = Convert.ToInt32(NumT);
            Console.WriteLine("3N");
            string NumThree = Console.ReadLine();
            int three = Convert.ToInt32(NumThree);
            if (one>two && one >three)
            {
                Console.WriteLine("The 1st Number is the greatest among three");
                Console.ReadKey();
            }
            else if (two>one && two>three)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
                Console.ReadKey();
            }
            else if (three>one && three>two)
            {
                Console.WriteLine("The 3 Number is the greatest among three");
                Console.ReadKey();
            }
            else if (one==two && one==three)
            {
                Console.WriteLine("The numbers are equal");
                Console.ReadKey();
            }
        }
    }
}
