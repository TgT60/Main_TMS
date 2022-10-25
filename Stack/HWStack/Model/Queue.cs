using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace HWStack.Model
{
    class Queue <T>
    {
        public List<T> Items = new List<T>();
        public int Count => Items.Count;
        public void Push(T item)
        {
            Items.Add(item);
        }
        public T Peek()
        {
            if (Count > 0)
            {
                var item = Items.First();
                Items.Remove(item);
                return Items.First();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        public T Pop()
        {
            if (Count > 0)
            {
                var item = Items.First();
                return Items.First();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        public void UiFromQueue()
        {

            var queue = new Queue<int>();

            queue.Push(1);
         

         
            var item2 = queue.Peek();
      

            Console.WriteLine(item2);
        }
    }
}
