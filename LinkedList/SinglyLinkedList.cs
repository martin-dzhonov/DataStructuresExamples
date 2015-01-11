using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class SinglyLinkedList<T>
    {
        public SimpleNode<T> First { get; set; }

        public SinglyLinkedList()
        {
            this.First = null;
        }

        public void AddFirst(SimpleNode<T> node)
        {
            node.Next = this.First;
            this.First = node;
        }

        public SinglyLinkedList(SimpleNode<T> node)
        {
            this.First = node;
        }

        public void InsertAfter(SimpleNode<T> node, SimpleNode<T> newNode)
        {
            newNode.Next = node.Next;
            node.Next = newNode;
        }

        public void InsertBefore(SimpleNode<T> node, SimpleNode<T> newNode)
        {      
            newNode.Next = node;
            if (node == this.First)
            {
                this.First = newNode;
            }
        }
    }
}
