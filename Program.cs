using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an operation");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter the first number") ;
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter the second number"); 
            string number2 = Console.ReadLine();
            int a = Convert.ToInt32(number1);
            int b = Convert.ToInt32(number2);
            switch (operation)
            {
                case "+":
                    Console.WriteLine(a+b);
                    Console.ReadLine();
                    break;
                case "-":
                    Console.WriteLine(a-b);
                    Console.ReadLine();
                    break;
                case "%":
                    double g = Convert.ToDouble(a);
                    Console.WriteLine(g/100);
                    Console.ReadLine();
                    break;
                case "*":
                    Console.WriteLine(a*b);
                    Console.ReadLine();
                    break;
                case "/":
                    double c = Convert.ToDouble(a);
                    double d = Convert.ToDouble(b);
                    Console.WriteLine(c%d);
                    break;
                case"SR":
                    double square_root = Math.Sqrt(a);
                    Console.WriteLine(square_root);
                    Console.ReadLine();
                    break;




            }
        }
    }
}
