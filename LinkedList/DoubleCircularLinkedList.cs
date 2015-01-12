using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DoubleCircularLinkedList<T>
    {
        public DoubleNode<T> First { get; set; }

        public DoubleNode<T> Last { get; set; }

        public DoubleCircularLinkedList(DoubleNode<T> node)
        {
            this.First = node;
            this.Last = node;
            node.Next = node;
            node.Prev = node;
        }

        public void InsertFirst(DoubleNode<T> node)
        {
            node.Next = this.First;
            node.Prev = this.Last;
            this.First = node;
        }

        public void InsertLast(DoubleNode<T> node)
        {
            node.Prev = this.Last;
            node.Next = this.First;
            this.Last = node;
        }

        public void InsertAfter(DoubleNode<T> node, DoubleNode<T> newNode)
        {
            newNode.Next = node.Next;
            newNode.Prev = node;
            node.Next = newNode;
            if (this.Last == node)
            {
                this.Last = newNode;
            }
        }

        public void InsertBefore(DoubleNode<T> node, DoubleNode<T> newNode)
        {
            newNode.Next = node;
            newNode.Prev = node.Prev;
            node.Prev = newNode;
            if (node == this.First)
            {
                this.First = newNode;
            }
        }

        public void RemoveAfter(DoubleNode<T> node)
        {
            node.Next = node.Next.Next;
        }

        public void RemoveBefore(DoubleNode<T> node)
        {
            node.Prev = node.Prev.Prev;
        }
    }
}
