using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SimpleNode<T>
    {
        public T Value { get; set; }
        public SimpleNode<T> Next { get; set; }

        public SimpleNode(T value)
        {
            this.Value = value;
        }
    }
}
