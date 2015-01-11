using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleNode<string> honda = new SimpleNode<string>("Honda");
            SimpleNode<string> bmw = new SimpleNode<string>("BMW");
            SimpleNode<string> mercedes = new SimpleNode<string>("Mercedes");

            SinglyLinkedList<string> singlyLinkedList = new SinglyLinkedList<string>();

            singlyLinkedList.AddFirst(honda);
            singlyLinkedList.InsertAfter(honda, bmw);
            singlyLinkedList.InsertAfter(bmw, mercedes);

            SimpleNode<string> node = singlyLinkedList.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
