using System;
using System.Collections.Generic;

class LRUCache
{
    int capacity;
    Dictionary<int, int> cache = new Dictionary<int, int>();
    LinkedList<int> order = new LinkedList<int>();

    public LRUCache(int cap)
    {
        capacity = cap;
    }

    public int Get(int key)
    {
        if (!cache.ContainsKey(key)) return -1;

        order.Remove(key);
        order.AddFirst(key);
        return cache[key];
    }

    public void Put(int key, int value)
    {
        if (cache.ContainsKey(key))
            order.Remove(key);
        else if (cache.Count == capacity)
        {
            int last = order.Last.Value;
            order.RemoveLast();
            cache.Remove(last);
        }

        cache[key] = value;
        order.AddFirst(key);
    }
}

class Program
{
    static void Main()
    {
        LRUCache lru = new LRUCache(2);
        lru.Put(1,10);
        lru.Put(2,20);

        Console.WriteLine(lru.Get(1));
    }
}