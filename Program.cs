using System;


namespace ConsoleApp2
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Select an operation\n 1)+ \n 2)- \n 3)% \n 4)* \n 5)/ \n 6)SR");
            string operation = Console.ReadLine();
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
                case "SR":
                    Squer();
                    break;
            }
        }
        static double SecondNum()
        {
            Console.WriteLine("Enter the second number");
            string number2 = Console.ReadLine();
            double plus2 = Convert.ToInt32(number2);
            return plus2;
        }
        static double FirstNum()
        {
            Console.WriteLine("Enter the first number");
            string number1 = Console.ReadLine();
            double plus1 = Convert.ToInt32(number1);
            return plus1;
        }
        static void Plus()
        {
            double plus1 = FirstNum();
            double plus2 = SecondNum();
            Console.WriteLine("Result is addition = " + (plus1 + plus2));
            Console.ReadLine();
        }
        static void Minus()
        {
            double minus1 = FirstNum();
            double minus2 = SecondNum();
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
            double multiplication1 = FirstNum();
            double multiplication2 = SecondNum();
            Console.WriteLine("Result of multiplication = " + (multiplication1 * multiplication2));
            Console.ReadLine();
        }
        static void DeMult()
        {
            double demultiplication1 = FirstNum();
            double demultiplication2 = SecondNum();
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
