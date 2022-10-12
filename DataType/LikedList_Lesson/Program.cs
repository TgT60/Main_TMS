using System;

namespace LikedList_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Table<int, string, bool> table = new Table<int,string, bool>();
            table.AddRow(2, "d", true);
            table.AddRow(3, "hf", false);
            table.AddRow(4, "gf", false);
            table.AddRow(5, "g", true);

            table.Print();
        }
    }
}
