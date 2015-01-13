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
            BinarySearchTree<string> binarySearchTree = new BinarySearchTree<string>();
            binarySearchTree.Insert("F");
            binarySearchTree.Insert("B");
            binarySearchTree.Insert("G");
            binarySearchTree.Insert("A");
            binarySearchTree.Insert("D");
            binarySearchTree.Insert("I");
            binarySearchTree.Insert("C");
            binarySearchTree.Insert("E");
            binarySearchTree.Insert("H");
            //tree pic: http://upload.wikimedia.org/wikipedia/commons/d/d4/Sorted_binary_tree_preorder.svg

            Console.WriteLine("BINARY TREE");
            Console.WriteLine("Pre-order traversal(DFS)");
            PreOrderTraversal(binarySearchTree.Root);
            Console.WriteLine("-------------------");

            Console.WriteLine("In-order traversal(DFS)");
            InOrderTraversal(binarySearchTree.Root);
            Console.WriteLine("-------------------");

            Console.WriteLine("Post-order traversal(DFS)");
            PostOrderTraversal(binarySearchTree.Root);
            Console.WriteLine("-------------------");

            Console.WriteLine("Level-order traversal(BFS)");
            LevelOrderTraversal(binarySearchTree.Root);
            Console.WriteLine("-------------------");

            AVLTree<string> avlTree = new AVLTree<string>();
            avlTree.Insert("A");
            avlTree.Insert("B");
            avlTree.Insert("C");
            avlTree.Insert("D");
            avlTree.Insert("E");
            avlTree.Insert("F");
            avlTree.Insert("G");
            avlTree.Insert("H");
            avlTree.Insert("I");

            Console.WriteLine("\nAVL TREE");
            Console.WriteLine("Level-order traversal(BFS)");
            LevelOrderTraversal(avlTree.Root);
            Console.WriteLine("-------------------");
        }

        public static void PreOrderTraversal<T>(BinaryNode<T> node) where T: IComparable
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Value);
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public static void InOrderTraversal<T>(BinaryNode<T> node) where T : IComparable
        {
            if (node == null)
            {
                return;
            }
            InOrderTraversal(node.Left);
            Console.WriteLine(node.Value);
            InOrderTraversal(node.Right);
        }

        public static void PostOrderTraversal<T>(BinaryNode<T> node) where T : IComparable
        {
            if (node == null)
            {
                return;
            }
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.WriteLine(node.Value);
        }

        public static void LevelOrderTraversal<T>(BinaryNode<T> node) where T : IComparable
        {
            Queue<BinaryNode<T>> queue = new Queue<BinaryNode<T>>();
            HashSet<BinaryNode<T>> visited = new HashSet<BinaryNode<T>>();
            queue.Enqueue(node);
            visited.Add(node);
            while (queue.Count > 0)
            {
                BinaryNode<T> currNode = queue.Dequeue();
                visited.Remove(currNode);
                if (!visited.Contains(currNode.Left) && currNode.Left != null)
                {
                    visited.Add(currNode.Left);
                    queue.Enqueue(currNode.Left);
                }
                if (!visited.Contains(currNode.Right) && currNode.Right != null)
                {
                    visited.Add(currNode.Right);
                    queue.Enqueue(currNode.Right);
                }
                Console.WriteLine(currNode.Value);
            }
        }
    }
}
