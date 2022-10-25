using HWStack.Model;
using System;

namespace HWStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var easyStack = new EasyStack<int>();

            easyStack.Push(1);
            easyStack.Push(2);
            easyStack.Push(3);

            var item = easyStack.Peek();
            var item2 = easyStack.Pop();
            var item3 = easyStack.Peek();

            Console.WriteLine(item);
            Console.WriteLine(item2);
            Console.WriteLine(item3);

        }
    }
}
