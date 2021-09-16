using System;
using System.Collections.Generic;
using System.Text;
namespace TLVRoofs
{
    public class Node<T>
    {
        public Node<T> Next;
        public Node<T> Prev;
        public T Data;

        public Node(T data) { Data = data; }

        public Node() { }

    }
}
