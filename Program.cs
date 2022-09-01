using System;


namespace ConsoleApp2
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Select an operation\n 1)+ \n 2)- \n 3)% \n 4)* \n 5)/ \n 6)SR");
            string operation = Console.ReadLine(); ;
            switch (operation)
            {
                case "+":
                    Plus();
                    break;
                case "-":
                    Minus();
                    break;
                case "%":
                    Proc();
                    break;
                case "*":
                    Mult();
                    break;
                case "/":
                    DeMult();
                    break;
                case"SR":
                    Squer();
                    break;
            }
        }
        static void Plus()
        {
            Console.WriteLine("Enter the first number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string number2 = Console.ReadLine();
            int plus1 = Convert.ToInt32(number1);
            int plus2 = Convert.ToInt32(number2);
            Console.WriteLine("Result is addition = " + (plus1 + plus2));
            Console.ReadLine();
        }
        static void Minus()
        {
            Console.WriteLine("Enter the first number");
            string number3 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string number4 = Console.ReadLine();
            int minus1 = Convert.ToInt32(number3);
            int minus2 = Convert.ToInt32(number4);
            Console.WriteLine("Result of subtraction = " + (minus1 - minus2));
            Console.ReadLine();
        }
        static void Proc()
        {
            Console.WriteLine("Enter number");
            string number5 = Console.ReadLine();
            double percent = Convert.ToDouble(number5);
            Console.WriteLine("One percent = " + (percent / 100));
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Enter the first number");
            string number6 = Console.ReadLine();
            int multiplication1 = Convert.ToInt32(number6);
            Console.WriteLine("Enter the second number");
            string number7 = Console.ReadLine();
            int multiplication2 = Convert.ToInt32(number7);
            Console.WriteLine("Result of multiplication = " + (multiplication1 * multiplication2));
            Console.ReadLine();
        }
        static void DeMult()
        {
            Console.WriteLine("Enter the first number");
            string number8 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string number9 = Console.ReadLine();
            double demultiplication1 = Convert.ToDouble(number8);
            double demultiplication2 = Convert.ToDouble(number9);
            Console.WriteLine("Result of demultiplication = " + (demultiplication1 / demultiplication2));
            Console.ReadKey();
        }
        static void Squer()
        {
            Console.WriteLine("Enter number");
            string number10 = Console.ReadLine();
            double sr = Convert.ToDouble(number10);
            double square_root = Math.Sqrt(sr);
            Console.WriteLine("The square root = " + square_root);
            Console.ReadLine();
        }

    }

}
