using System;

class CircularQueue
{
    int[] q = new int[5];
    int front = -1, rear = -1;

    public void Enqueue(int x)
    {
        if ((rear + 1) % q.Length == front)
            Console.WriteLine("Full");
        else
        {
            if (front == -1) front = 0;
            rear = (rear + 1) % q.Length;
            q[rear] = x;
        }
    }

    public void Dequeue()
    {
        if (front == -1)
            Console.WriteLine("Empty");
        else
        {
            Console.WriteLine("Deleted: " + q[front]);
            if (front == rear)
                front = rear = -1;
            else
                front = (front + 1) % q.Length;
        }
    }

    static void Main()
    {
        CircularQueue c = new CircularQueue();
        c.Enqueue(1); c.Enqueue(2); c.Enqueue(3);
        c.Dequeue();
    }
}