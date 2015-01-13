using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Insert(5);
            binarySearchTree.Insert(10);
            binarySearchTree.Insert(2);
            binarySearchTree.Insert(15);
            binarySearchTree.Insert(12);

            Traverse(binarySearchTree.Root);
        }

        public static void Traverse(BinaryNode<int> node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Value);
            Traverse(node.Left);
            Traverse(node.Right);
        }
    }
}
