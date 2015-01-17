using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class AVLTree<T> where T : IComparable<T>
    {
        public BinaryNode<T> Root { get; set; }
        
        public AVLTree()
        {

        }

        public void Insert(T value)
        {
            BinaryNode<T> newItem = new BinaryNode<T>(value);
            if (this.Root == null)
            {
                this.Root = newItem;
            }
            else
            {
                this.Root = this.RecursiveInsert(this.Root, newItem);
            }
        }

        public void Delete(T value)
        {
            //TODO: Add Remove() method
            throw new NotImplementedException();
        }

        private BinaryNode<T> RecursiveInsert(BinaryNode<T> node, BinaryNode<T> newNode)
        {
            if (node == null)
            {
                node = newNode;
                return node;
            }
            else if (newNode.Value.CompareTo(node.Value) < 0)
            {
                node.Left = this.RecursiveInsert(node.Left, newNode);
                node = this.BalanceTree(node);
            }
            else if (newNode.Value.CompareTo(node.Value) > 0)
            {
                node.Right = this.RecursiveInsert(node.Right, newNode);
                node = this.BalanceTree(node);
            }
            return node;
        }

        private BinaryNode<T> BalanceTree(BinaryNode<T> node)
        {
            int balanceFactor = this.GetBalanceFactor(node);
            if (balanceFactor > 1)
            {
                if (this.GetBalanceFactor(node.Left) > 0)
                {
                    node = this.RotateLL(node);
                }
                else
                {
                    node = this.RotateLR(node); 
                }   
            }
            else if (balanceFactor < -1)
            {
                if (this.GetBalanceFactor(node.Right) > 0)
                {
                    node = this.RotateRL(node);
                }
                else
                {
                    node = this.RotateRR(node);
                }
            }
            return node;
        }

        private BinaryNode<T> RotateRR(BinaryNode<T> parent)
        {
            BinaryNode<T> pivot = parent.Right;
            parent.Right = parent.Left;
            pivot.Left = parent;
            return pivot;
        }

        private BinaryNode<T> RotateLL(BinaryNode<T> parent)
        {
            BinaryNode<T> pivot = parent.Left;
            parent.Left = pivot.Right;
            pivot.Right = parent;
            return pivot;
        }

        private BinaryNode<T> RotateLR(BinaryNode<T> parent)
        {
            BinaryNode<T> pivot = parent.Left;
            parent.Left = RotateRR(pivot);
            return RotateLL(parent);
        }

        private BinaryNode<T> RotateRL(BinaryNode<T> parent)
        {
            BinaryNode<T> pivot = parent.Right;
            parent.Right = RotateLL(pivot);
            return RotateRR(parent);
        }

        private int GetHeight(BinaryNode<T> node)
        {
            int height = 0;
            if (node != null)
            {
                int leftHeight = this.GetHeight(node.Left);
                int rightHeight = this.GetHeight(node.Right);
                int greaterHeight = Math.Max(leftHeight, rightHeight);
                height = greaterHeight + 1;
            }
            return height;
        }

        private int GetBalanceFactor(BinaryNode<T> node)
        {
            int rightFactor = this.GetHeight(node.Right);
            int leftFactor = this.GetHeight(node.Left);
            int balanceFactor = leftFactor - rightFactor;
            return balanceFactor;
        }
    }
}
