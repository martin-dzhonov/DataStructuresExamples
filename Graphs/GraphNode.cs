using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class GraphNode<T>
    {
        public T Value { get; set; }

        public List<GraphNode<T>> Neighbors { get; set; }

        public List<int> Costs { get; set; }

        public GraphNode(T value)
        {
            this.Value = value;
            this.Neighbors = new List<GraphNode<T>>();
            this.Costs = new List<int>();
        }

    }
}
