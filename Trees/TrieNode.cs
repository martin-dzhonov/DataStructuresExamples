using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class TrieNode<T> where T :class
    {
        public T Value { get; set; }

        public char Key { get; private set; }

        public TrieNode<T> Parent { get; private set; }

        public bool IsLeaf
        {
            get
            {
                return this.ChildrenCount() == 0;
            }
        }

        public bool IsTerminater
        {
            get
            {
                return Value != null;
            }
        }
        private Dictionary<char, TrieNode<T>> children;

        public TrieNode(TrieNode<T> parent, char key)
        {
            this.Key = key;
            this.Value = null;
            this.Parent = parent;
            this.children = new Dictionary<char, TrieNode<T>>();
        }

        public TrieNode<T> GetChild(char key)
        {
            if (children.ContainsKey(key))
            {
                return children[key];
            }
            return null;
        }

        public int ChildrenCount()
        {
            return children.Count;
        }

        public TrieNode<T> AddChild(char key)
        {
            if (children.ContainsKey(key))
            {
                return children[key];
            }
            else
            {
                TrieNode<T> newChild = new TrieNode<T>(this, key);
                children.Add(key, newChild);
                return newChild;
            }
        }

        public void RemoveChild(char key)
        {
            children.Remove(key);
        }

        public List<T> GetPrefixMatches()
        {
            if (this.IsLeaf)
            {
                if (this.IsTerminater)
                {
                    return new List<T>(new T[] { this.Value });
                }
                else
                {
                    return new List<T>();
                }
            }
            else
            {
                List<T> values = new List<T>();
                foreach (TrieNode<T> node in children.Values)
                {
                    values.AddRange(node.GetPrefixMatches());
                }

                if (IsTerminater)
                {
                    values.Add(Value);
                }

                return values;
            }
        }
    }
}
