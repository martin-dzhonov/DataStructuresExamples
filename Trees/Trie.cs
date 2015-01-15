using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Trie<T> where T:class
    {
        public TrieNode<T> Root { get; private set; }
        public Trie()
        {
            this.Root = new TrieNode<T>(null, '\0');
        }

        public void Insert(string word, T value)
        {
            TrieNode<T> node = this.Root;
            foreach (char c in word)
            {
                node = node.AddChild(c);
            }
            node.Value = value;
        }
    }
}
