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
            //pic: http://upload.wikimedia.org/wikipedia/commons/d/d4/Sorted_binary_tree_preorder.svg

            Console.WriteLine("BINARY TREE");
            Console.WriteLine("\nPre-order traversal(DFS)");
            PreOrderTraversal(binarySearchTree.Root);

            Console.WriteLine("\nIn-order traversal(DFS)");
            InOrderTraversal(binarySearchTree.Root);

            Console.WriteLine("\nPost-order traversal(DFS)");
            PostOrderTraversal(binarySearchTree.Root);

            Console.WriteLine("\nLevel-order traversal(BFS)");
            LevelOrderTraversal(binarySearchTree.Root);

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
            Console.WriteLine("\nLevel-order traversal(BFS)");
            LevelOrderTraversal(avlTree.Root);

            Console.WriteLine("\nBINARY HEAP");
            BinaryHeap<int> binaryHeap = new BinaryHeap<int>(Comparer<int>.Create(new Comparison<int>(MaxIntCompare)));
            binaryHeap.Insert(1);
            binaryHeap.Insert(2);
            binaryHeap.Insert(3);
            binaryHeap.Insert(7);
            binaryHeap.Insert(17);
            binaryHeap.Insert(19);
            binaryHeap.Insert(25);
            binaryHeap.Insert(36);
            binaryHeap.Insert(100);
            //pic: http://upload.wikimedia.org/wikipedia/commons/3/38/Max-Heap.svg

            Console.WriteLine();
            Console.WriteLine("Heap root: " + binaryHeap.Peek());
            Console.WriteLine("Root popped: " + binaryHeap.Pop());
            Console.WriteLine("New root: " + binaryHeap.Peek());

            Trie trieDS = new Trie();
            TrieNode rootNode = new TrieNode();
            rootNode = trieDS.CreateNode();
            trieDS.AddWord("Name One", rootNode, "1");
            trieDS.AddWord("Name Two", rootNode, "2");
            trieDS.AddWord("asdf", rootNode, "4");
            Console.WriteLine();
           // TrieNode matchedNode = trieDS.GetMatchedNode("Name", rootNode);
            List<string> asdf =  trieDS.GetAutoCompleteList(rootNode, "Name", new List<string>());
            for (int i = 0; i < asdf.Count; i++)
            {
                Console.WriteLine(asdf[i]);
            }
        }

        public static void PreOrderTraversal<T>(BinaryNode<T> node) where T : IComparable<T>
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Value);
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public static void InOrderTraversal<T>(BinaryNode<T> node) where T : IComparable<T>
        {
            if (node == null)
            {
                return;
            }
            InOrderTraversal(node.Left);
            Console.WriteLine(node.Value);
            InOrderTraversal(node.Right);
        }

        public static void PostOrderTraversal<T>(BinaryNode<T> node) where T : IComparable<T>
        {
            if (node == null)
            {
                return;
            }
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.WriteLine(node.Value);
        }

        public static void LevelOrderTraversal<T>(BinaryNode<T> node) where T : IComparable<T>
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

        public static int MaxIntCompare(int first, int second)
        {
            if (first < second)
            {
                return 1;
            }
            else if (first > second)
            {
                return -1;
            }
            return 0;
        }
    }
}
