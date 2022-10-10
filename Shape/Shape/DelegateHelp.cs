using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape
{
    class DelegateHelp
    {
        delegate void Message(string text);
        delegate void Message2();     

        public void Test(string a)
        {
            Message message;
            message = Display;
            message(a);
           
        }
        public void Test2()
        {
            Message2 message2;
            message2 = Display2;
            message2();
        }
        public void Test3(string b)
        {
            Message message3;
            message3 = Display3;
            message3(b);
        }
        public void Test4()
        {
            Message2 message4;
            message4 = Display4;
            message4();
        }
        public void Test5(string a)
        {
            Message message5;                    
        }
        public void Display(string text)
        {
            Console.WriteLine(text);
        }
        public void Display2()
        {
            Console.WriteLine();
        }
        public void Display3(string b)
        {
            Console.Write(b);
        }
        public void Display4()
        {
            Console.ReadKey();
        }
        public string Display5(string a)
        {
            Console.ReadLine();
            return a;
        }
    }   
}
