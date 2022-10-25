using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HWStack.Model
{
    class EasyStack<T>
    {
        private List<T> Items = new List<T>();
        public int Count => Items.Count;
  
        public void Push(T item)
        {
            Items.Add(item);
        }
        public T Pop()
        {
            if (Count > 0)
            {
                var item = Items.LastOrDefault();
                Items.Remove(item);
                return Items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public T Peek()
        {
            if (Count > 0)
            {
                var item = Items.LastOrDefault();
    
                return Items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
