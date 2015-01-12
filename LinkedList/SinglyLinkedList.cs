using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class SinglyLinkedList<T>
    {
        public BasicNode<T> First { get; set; }

        public SinglyLinkedList()
        {
            this.First = null;
        }

        public SinglyLinkedList(BasicNode<T> node)
        {
            this.First = node;
        }

        public void InsertFirst(BasicNode<T> node)
        {
            node.Next = this.First;
            this.First = node;
        }

        public void InsertAfter(BasicNode<T> node, BasicNode<T> newNode)
        {
            newNode.Next = node.Next;
            node.Next = newNode;
        }

        public void InsertBefore(BasicNode<T> node, BasicNode<T> newNode)
        {      
            newNode.Next = node;
            if (node == this.First)
            {
                this.First = newNode;
            }
        }
    }
}
