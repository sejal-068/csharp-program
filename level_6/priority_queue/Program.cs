using System;
using System.Collections.Generic;

class PriorityQueue
{
    private List<int> heap = new List<int>();

    private void Swap(int i, int j)
    {
        int temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }

    public void Enqueue(int value)
    {
        heap.Add(value);
        int i = heap.Count - 1;

        while (i > 0 && heap[i] < heap[(i - 1) / 2])
        {
            Swap(i, (i - 1) / 2);
            i = (i - 1) / 2;
        }
    }

    public int Dequeue()
    {
        int root = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);

        Heapify(0);
        return root;
    }

    private void Heapify(int i)
    {
        int smallest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < heap.Count && heap[left] < heap[smallest])
            smallest = left;

        if (right < heap.Count && heap[right] < heap[smallest])
            smallest = right;

        if (smallest != i)
        {
            Swap(i, smallest);
            Heapify(smallest);
        }
    }
}