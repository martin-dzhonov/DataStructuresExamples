using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class BasicNode<T>
    {
        public T Value { get; set; }
        public BasicNode<T> Next { get; set; }

        public BasicNode(T value)
        {
            this.Value = value;
        }
    }
}
