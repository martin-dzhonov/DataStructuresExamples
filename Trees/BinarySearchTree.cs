using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinarySearchTree<T> where T : IComparable
    {
        public BinaryNode<T> Root { get; set; }

        public BinarySearchTree() { }

        public BinarySearchTree(T value)
        {
            this.Root = new BinaryNode<T>(value);
        }
        public bool Insert(T value)
        {
            if (this.Root == null)
            {
                this.Root = new BinaryNode<T>(value);
                return true;
            }
            else
            {
                return Root.Add(value);
            }
        }

        public BinaryNode<T> Search(T value)
        {
            return this.Root.Search(value);
        }
    }
}
