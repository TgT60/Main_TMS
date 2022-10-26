using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program

    {
        static void Main(string[] args)
        {
            int reload = 1;
            while (reload == 1)
            {
                    Console.WriteLine("Choise Enter tipe 1 or 2");
                try
                {
                    int k = Convert.ToInt32(Console.ReadLine());

                    if (k == 1)
                    {
                        try
                        {
                            Console.WriteLine("Enter Example");
                            string s1 = Console.ReadLine();
                            char fun = ' ';
                            string s1WithoutSpace = s1.Replace(" ", "");
                            char[] Register = { '+', '-', '*', '/' };
                            for (int i = 0; i < 4; i++)
                            {
                                if (s1.Contains(Register[i]))
                                {
                                    fun = Register[i];
                                }
                            }
                            string[] parts = s1WithoutSpace.Split('+', '-', '/', '*');
                            double c = Convert.ToDouble(parts[0]);
                            double b = Convert.ToDouble(parts[1]);
                            string conf = Convert.ToString(fun);
                            Console.ReadKey();


                            SwAndCase(conf, b, c);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter Corect example");
                        }
                    }
                    else if (k == 2)
                    {
                        SwAndCase(ChoseOP(), EnterSecondNum(), EnterFirstNum());
                    }
                    else
                    {
                        Console.WriteLine("Pleas choise correct operation");
                    }
                    Console.WriteLine("Else you want to use program again enter 1");
                    int reload2 = Convert.ToInt32(Console.ReadLine());
                    if (reload2 == 1)
                    {
                        reload = 1;
                    }
                    else
                    {
                        reload = 2;
                    }
                }
                catch(FormatException)           
                {
                    Console.WriteLine("Pleas choise correct operation");
                }
               
            }
        }

        static void SwAndCase(string c, double a, double b )
        {

            switch (c)
            {
                case "+":
                    Plus(a, b) ;
                    break;
                case "-":
                    Minus(a, b) ;
                    break;
                case "%":
                    Proc(a);
                    break;
                case "*":
                    Mult(a, b) ;
                    break;
                case "/":
                    DeMult(a, b);
                    break;
                case "SR":
                    Squer(a);
                    break; 
            }
        }
        static double EnterFirstNum()
        {
            Console.WriteLine("Enter number");
            string number = Console.ReadLine();
            double a = Convert.ToDouble(number);
            return a;
        }
        static double EnterSecondNum()
        {
            Console.WriteLine("Enter number");
            string number = Console.ReadLine();
            double b = Convert.ToDouble(number);
            return b;
        }
        
        static string ChoseOP()
        {
            Console.WriteLine(" Select an operation\n 1)+ \n 2)- \n 3)% \n 4)* \n 5)/ \n 6)SR \n");
            string operation = Console.ReadLine();
            return operation;

        }
        static void Plus(double a, double b)
        {
            Console.WriteLine("Result is addition = " + (a + b));
            Console.ReadLine();
        }
        static void Minus(double a, double b)
        {
            Console.WriteLine("Result of subtraction = " + (a - b ));
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