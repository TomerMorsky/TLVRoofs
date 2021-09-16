using System;
using System.Collections.Generic;
using System.Text;

namespace TLVRoofs
{
    public class NodesList<T>
    {
        public Node<T> Head { get; set; }

        public NodesList()
        {
            Head = null;
        }

        public void AddFirst(T data)
        {
            var addedNode = new Node<T>(data);
            addedNode.Next = Head;
            Head = addedNode;
        }

        public Node<T> RemoveFirst()
        {
            Node<T> nodeToRermove = Head;
            Head = nodeToRermove.Next;
            return nodeToRermove;
        }

    }
}
