using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node<T>
    {   
        public T Data { get; }
        public Node<T> Tail { get; set; }
        public Node(T data)
        {
            Data = data;
        }
    }
}
