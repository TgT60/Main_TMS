using System;


namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter anouther number");
            int b = Convert.ToInt32(Console.ReadLine());
            Solut(a, b);
            Console.ReadKey();
        }
        static void Solut(int a, int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
            Console.WriteLine("Now the 1st number is " + a + " and the 2nd number is : " + b);
        }
    }
}
