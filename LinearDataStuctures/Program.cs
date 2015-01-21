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
            BasicNode<string> honda = new BasicNode<string>("Honda");
            BasicNode<string> bmw = new BasicNode<string>("BMW");
            BasicNode<string> mercedes = new BasicNode<string>("Mercedes");

            SinglyLinkedList<string> singlyLinkedList = new SinglyLinkedList<string>();

            singlyLinkedList.InsertFirst(honda);
            singlyLinkedList.InsertAfter(honda, bmw);
            singlyLinkedList.InsertAfter(bmw, mercedes);

            BasicNode<string> basicNode = singlyLinkedList.First;
            while (basicNode != null)
            {
                Console.WriteLine(basicNode.Value);
                basicNode = basicNode.Next;
            }

        }
    }
}
