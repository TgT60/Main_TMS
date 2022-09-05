using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine(a);
            int b = 6;
            Console.WriteLine(b);
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();

        }
    }
}
