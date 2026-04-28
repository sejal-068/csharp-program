using System;

class TrieNode
{
    public TrieNode[] children = new TrieNode[26];
    public bool isEnd;
}

class Trie
{
    TrieNode root = new TrieNode();

    public void Insert(string word)
    {
        TrieNode node = root;
        foreach (char c in word)
        {
            int i = c - 'a';
            if (node.children[i] == null)
                node.children[i] = new TrieNode();
            node = node.children[i];
        }
        node.isEnd = true;
    }

    public bool Search(string word)
    {
        TrieNode node = root;
        foreach (char c in word)
        {
            int i = c - 'a';
            if (node.children[i] == null)
                return false;
            node = node.children[i];
        }
        return node.isEnd;
    }
}

class Program
{
    static void Main()
    {
        Trie t = new Trie();
        t.Insert("cat");
        Console.WriteLine(t.Search("cat"));
    }
}