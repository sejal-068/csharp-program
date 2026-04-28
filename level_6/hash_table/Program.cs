using System;

class HashTable
{
    int[] table;
    int size;

    public HashTable(int size)
    {
        this.size = size;
        table = new int[size];
        for (int i = 0; i < size; i++)
            table[i] = -1;
    }

    int Hash(int key) => key % size;

    public void Insert(int key)
    {
        int index = Hash(key);
        while (table[index] != -1)
            index = (index + 1) % size;
        table[index] = key;
    }

    public void Display()
    {
        for (int i = 0; i < size; i++)
            Console.WriteLine($"{i} -> {table[i]}");
    }
}

class Program
{
    static void Main()
    {
        HashTable h = new HashTable(5);
        h.Insert(10);
        h.Insert(15);
        h.Insert(7);

        h.Display();
    }
}