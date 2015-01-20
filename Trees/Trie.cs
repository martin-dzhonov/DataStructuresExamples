using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Trie
    {
        public TrieNode CreateNode()
        {
            return new TrieNode();
        }

        public void AddWord(string word, TrieNode rootNode, string id)
        {
            int len = word.Length;
            if (len == 0)
            {
                rootNode.PrefixCount++;
                rootNode.IsWord = true;
                return;
            }
            for (int i = 0; i < len; i++)
            {
                char key = word[i];
                if (!rootNode.Children.ContainsKey(key))
                {
                    rootNode.Children.Add(key, new TrieNode());
                    rootNode.Children[key].Key = key;
                }
                rootNode.PrefixCount++;
                rootNode = rootNode.Children[key];
            }
            rootNode.IsWord = true;
        }

        public void RemoveWord(string word, TrieNode rootNode, string id)
        {
            int len = word.Length;
            if (len == 0)
            {
                rootNode.PrefixCount--;
                if (rootNode.PrefixCount == 0)
                    rootNode.IsWord = false;
                return;
            }
            for (int i = 0; i < len; i++)
            {
                char key = word[i];
                rootNode.PrefixCount--;
                rootNode = rootNode.Children[key];
            }
        }

        public TrieNode GetMatchedNode(string prefix, TrieNode rootNode)
        {
            int len = prefix.Length;
            if (len > 0)
            {
                for (int i = 0; i < len; i++)
                {
                    char key = prefix[i];
                    if (!rootNode.Children.ContainsKey(key))
                        return null;
                    rootNode = rootNode.Children[key];
                }
                return rootNode;
            }
            return null;
        }

        public List<string> GetAutoCompleteList(TrieNode matchedNode, string completeWord, List<string> wordList)
        {
            foreach (var item in matchedNode.Children)
            {
                string tmpWord = completeWord + item.Value.Key;
                if (item.Value.IsWord)
                {
                    if (!wordList.Contains(tmpWord))
                    {
                        wordList.Add(tmpWord);
                    }
                }
                GetAutoCompleteList(item.Value, tmpWord, wordList);
            }
            return wordList;
        }
    }
}
