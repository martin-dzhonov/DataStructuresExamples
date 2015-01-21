using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Trie
    {
        public TrieNode Root { get; private set; }

        public Trie()
        {
            this.Root = new TrieNode();
        }

        public void Add(string word)
        {
            var node = this.Root;
            foreach (char ch in word)
            {
                node = node.FindOrCreate(ch);
            }
            node.EndsWord = true;
        }

        public List<string> GetMatchedWords(string prefix)
        {
            var wordList = new List<string>();
            var node = this.GetMatchedNode(prefix);
            if (node != null)
            {
                node.ToList(ref wordList);
            }
            return wordList;
        }

        private TrieNode GetMatchedNode(string word)
        {
            var node = this.Root;
            foreach (char ch in word)
            {
                if (node.ContainsKey(ch))
                {
                    node = node[ch];
                }
                else
                {
                    return null;
                }
            }
            return node;
        }
    }
}
