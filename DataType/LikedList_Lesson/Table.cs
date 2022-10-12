using System;
using System.Collections.Generic;
using System.Text;

namespace LikedList_Lesson
{
    public class Table<T, U, Z>
    {
        public  static List<T> Ferst { get; set; }
        public static List<U> Second { get; set; }
        public static List<Z> Three { get; set; }
        public Table()
        {
            Ferst = new List<T>();
            Second = new List<U>();
            Three = new List<Z>();
        }
 
        public void AddRow(T ferst, U second, Z three)
        {
            Ferst.Add(ferst);
            Second.Add(second);
            Three.Add(three);
        }
        public void Print2()
        {
            Ferst.GetType();
            Second.GetType();
            Three.GetType();
        }
        public void Print()
        {
            for (int i = 0; i < Ferst.Count; i++)
            {
                Console.WriteLine($"|{Ferst[i]}|{Second[i]}|{Three[i]}|");
            }                   
        }
    }
}
