using System;


namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1N");
            string one = Console.ReadLine();
            double NumO = Convert.ToDouble(one);
            Console.WriteLine("2N");
            string two = Console.ReadLine();
            double NumT = Convert.ToDouble(two);
            Console.WriteLine("3N");
            string three = Console.ReadLine();
            double NumThree = Convert.ToDouble(three);
            if (NumO >=20&& NumO <=50 || NumT>=20 && NumT<=50 ||NumThree>=20 &&NumThree<=50)
            {
                Console.WriteLine(true);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(false);
                Console.ReadKey();
            }    
        }
    }
}
