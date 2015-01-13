using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryNode<T>  where T : IComparable
    {
        public T Value { get; set; }

        public BinaryNode<T> Left { get; set; }

        public BinaryNode<T> Right { get; set; }

        public BinaryNode(T value)
        {
            this.Value = value;
        }

        public bool Add(T value)
        {
            if (value.Equals(this.Value))
            {
                return false;
            }
            else if(value.CompareTo(this.Value) < 0)
            {
                if (this.Left == null)
                {
                    this.Left = new BinaryNode<T>(value);
                    return true;
                }
                else
                {
                    return this.Left.Add(value);
                }
            }
            else if (value.CompareTo(this.Value) > 0)
            {
                if (this.Right == null)
                {
                    this.Right = new BinaryNode<T>(value);
                    return true;
                }
                else
                {
                    return this.Right.Add(value);
                }
            }
            return false;
        }

        public BinaryNode<T> Search(T value)
        {
            if (this == null)
            {
                return null;
            }
            if (this.Value.Equals(value))
            {
                return this;
            }
            else if (this.Value.CompareTo(value) < 0)
            {
                this.Right.Search(value);
            }
            else if(this.Value.CompareTo(value) > 0)
            {
                this.Left.Search(value);
            }

            throw new Exception();
        }

    }
}
