using System;


namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            int NumOne = Convert.ToInt32(one);
            string two = Console.ReadLine();
            int NumTwo = Convert.ToInt32(two);
            string three = Console.ReadLine();
            int NumThree = Convert.ToInt32(three);
            Console.WriteLine(NumOne * NumTwo * NumThree);
            Console.ReadKey();

            
        }
    }
}
