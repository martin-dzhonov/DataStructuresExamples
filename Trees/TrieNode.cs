using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; private set; }

        public bool IsWord { get; set; }

        public int PrefixCount { get; set; }

        public char Key { get; set; }

        public TrieNode()
        {
            this.Children = new Dictionary<char, TrieNode>();
        }

        public TrieNode(char key)
        {
            this.Children = new Dictionary<char, TrieNode>();
            this.Key = key;
        }
    }
}
