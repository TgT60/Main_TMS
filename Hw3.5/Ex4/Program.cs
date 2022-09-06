using System;


namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int sum = 0;
            double overage = 0 ;
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("Enter Number ");
                string m = Console.ReadLine();
                int n = Convert.ToInt32(m);
                Console.WriteLine("Numbre "+ i +" = "+n);
                sum = sum + n;
                overage = (sum + n)/10;
                if (i==10)
                {
                    Console.WriteLine("sum "+sum);
                    Console.WriteLine("overage "+overage);
                    Console.ReadKey();
                }
            }
        }
    }
}
