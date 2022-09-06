using System;


namespace ConsoleApp2
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Select an operation\n 1)+ \n 2)- \n 3)% \n 4)* \n 5)/ \n 6)SR \n 7)EX");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter number");
            string ent = Console.ReadLine();
            double a = Convert.ToDouble(ent);
            Console.WriteLine("Enter number");
            string ent2 = Console.ReadLine();
            double b = Convert.ToDouble(ent2);

            switch (operation)
            {
                case "+":
                    Plus(a, b);
                    break;
                case "-":
                    Minus(a, b);
                    break;
                case "%":
                    Proc(a);
                    break;
                case "*":
                    Mult(a, b);
                    break;
                case "/":
                    DeMult(a, b);
                    break;
                case "SR":
                    Squer(a);
                    break;
                case "EX":
                    Console.WriteLine("Enter Example");
                    string s1 = Console.ReadLine();
                    char plus = '+';
                    int indexOfChar = s1.IndexOf(plus);
                    
                    s1 = s1.Trim();
                    Console.WriteLine(s1);
                    string[] sp = s1.Split('+');
                  
                    for (; ; )
                    {
                        Console.WriteLine($"<{word}>");
                        word = word.Trim();
                    }

                    Console.WriteLine(indexOfChar);
                    Console.ReadKey();
                    break;

            }
        }
        static double EnterNum()
        {
            Console.WriteLine("Enter number");
            string number5 = Console.ReadLine();
            double percent = Convert.ToDouble(number5);
            return percent;

        }

        static void Plus(double a, double b)
        {
            Console.WriteLine("Result is addition = " + (a + b));
            Console.ReadLine();
        }
        static void Minus(double a, double b)
        {
            Console.WriteLine("Result of subtraction = " + (a - b));
            Console.ReadLine();
        }
        static void Proc(double a)
        {
            Console.WriteLine("One percent = " + (a / 100));
            Console.ReadLine();
        }
        static void Mult(double a, double b)
        {

            Console.WriteLine("Result of multiplication = " + (a * b));
            Console.ReadLine();
        }
        static void DeMult(double a, double b)
        {
            Console.WriteLine("Result of demultiplication = " + (a / b));
            Console.ReadKey();
        }
        static void Squer(double a)
        {
            double square_root = Math.Sqrt(a);
            Console.WriteLine("The square root = " + square_root);
            Console.ReadLine();
        }

    }

}
