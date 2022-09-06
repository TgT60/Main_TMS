using System;


namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Wellocme(name);
            Nice();
            Console.ReadKey();
        }
        static void Wellocme(string name)
        {
            Console.WriteLine("Welcome friends " + name);

        }
        static void Nice()
        {
            Console.WriteLine("Have a nice day");
        }

    }
}
