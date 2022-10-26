using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class NodeList <T>
    {
        public Node<T> Head { get; set; }
        public NodeList(T firstListData)
        {
            Head = new Node<T>(firstListData);
        }
        public void AddList(T data)
        {
            Node<T> current = Head;
            while (current.Tail != null)
            {
                current = current.Tail;
            }
            current.Tail  = new Node<T>(data);
        }
        public void Loop(Action<object> action)
        {
            Node<T> current = Head;
            while (current != null)
            {
                action(current.Data);

                current = current.Tail;
            }

        }
    }
}
