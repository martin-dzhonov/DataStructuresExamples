using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DoubleNode<T>
    {
        public T Value;

        public DoubleNode<T> Next { get; set; }

        public DoubleNode<T> Prev { get; set; }

        public DoubleNode(T value)
        {
            this.Value = value;
        }

    }
}
