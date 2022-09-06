using System;


namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the marks obtained in Physics");
            string NumO = Console.ReadLine();
            int one = Convert.ToInt32(NumO);
            Console.WriteLine("Input the marks obtained in Chemistry");
            string NumT = Console.ReadLine();
            int two = Convert.ToInt32(NumT);
            Console.WriteLine("Input the marks obtained in Mathematics");
            string NumThree = Console.ReadLine();
            int three = Convert.ToInt32(NumThree);
            int sum = one + two + three;
            if ((three>=65 && two >= 55 && one>=50) &&  sum>=180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The candidate can't enter the university");
                Console.ReadKey();
            }
        }
    }
}
