using System;
using System.Collections.Generic;
using System.Text;

namespace LikedList_Lesson
{
    public class Table<T, U, Z>
    {
        public static List<T> First { get; set; }
        public static List<U> Second { get; set; }
        public static List<Z> Three { get; set; }
        public Table()
        {
            First = new List<T>();
            Second = new List<U>();
            Three = new List<Z>();
        }
        public void ConsFirst()
        {
            if (First.GetType() == typeof(string))
            {
                string a = Console.ReadLine();
                First.Add(a);   
            }
        
        }
 
        public void AddRow(T ferst, U second, Z three)
        {
            First.Add(ferst);
            Second.Add(second);
            Three.Add(three);
        }
        public void Print2()
        {
            First.GetType();
            Second.GetType();
            Three.GetType();
        }
        public void Print()
        {
            for (int i = 0; i < First.Count; i++)
            {
                Console.WriteLine($"|{First[i]}|{Second[i]}|{Three[i]}|");
            }                   
        }
    }
}
