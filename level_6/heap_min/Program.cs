using System;
using System.Collections.Generic;

class MinHeap
{
    List<int> heap = new List<int>();

    public void Insert(int val)
    {
        heap.Add(val);
        int i = heap.Count - 1;

        while (i > 0 && heap[i] < heap[(i - 1) / 2])
        {
            int temp = heap[i];
            heap[i] = heap[(i - 1) / 2];
            heap[(i - 1) / 2] = temp;
            i = (i - 1) / 2;
        }
    }

    public void Display()
    {
        foreach (var i in heap)
            Console.Write(i + " ");
    }
}

class Program
{
    static void Main()
    {
        MinHeap h = new MinHeap();
        h.Insert(10);
        h.Insert(5);
        h.Insert(20);

        h.Display();
    }
}