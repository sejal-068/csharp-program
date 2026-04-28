using System;

class QueueArray
{
    int[] q = new int[5];
    int front = 0, rear = -1;

    public void Enqueue(int x)
    {
        if (rear == q.Length - 1)
            Console.WriteLine("Overflow");
        else
            q[++rear] = x;
    }

    public void Dequeue()
    {
        if (front > rear)
            Console.WriteLine("Underflow");
        else
            Console.WriteLine("Deleted: " + q[front++]);
    }

    public void Display()
    {
        for (int i = front; i <= rear; i++)
            Console.Write(q[i] + " ");
    }

    static void Main()
    {
        QueueArray q = new QueueArray();
        q.Enqueue(10); q.Enqueue(20); q.Enqueue(30);
        q.Dequeue();
        q.Display();
    }
}