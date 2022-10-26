using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            NodeList<string> nodeList = new NodeList<string>("1");
            nodeList.AddList("2");
            nodeList.AddList("3");
            nodeList.AddList("4");
            nodeList.Loop(x =>Console.WriteLine(x));
        }
    }
}
