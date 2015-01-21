using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class AdjacencyListGraph<T>
    {
        private List<GraphNode<T>> nodes;

        public AdjacencyListGraph()
        {
            this.nodes = new List<GraphNode<T>>();
        }

        public void AddNode(GraphNode<T> node)
        {
            this.nodes.Add(node);
        }
        public void AddDirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost)
        {
            from.Neighbors.Add(to);
            from.Costs.Add(cost);
        }

        public void AddUndirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost)
        {
            from.Neighbors.Add(to);
            from.Costs.Add(cost);

            to.Neighbors.Add(from);
            to.Costs.Add(cost);
        }

        public bool Contains(T value)
        {
            return nodes.Any(n => n.Value.Equals(value));
        }

    }
}
