using System;



namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1N");
            string one = Console.ReadLine();
            double NumO = Convert.ToDouble(one);
            if (NumO == 51)
            {
                Console.WriteLine(NumO = 0);
                Console.ReadKey();
            }
            else if(NumO<51)
            {
                Console.WriteLine(51-NumO);
                Console.ReadKey();
            }
            else if(NumO>51)
            {
                Console.WriteLine(NumO*3%51);
                Console.ReadKey( );

            }

        }
    }
}
