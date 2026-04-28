using System;

class Node
{
    public int data;
    public Node next;
}

class QueueLL
{
    Node front = null, rear = null;

    public void Enqueue(int x)
    {
        Node temp = new Node { data = x };

        if (rear == null)
            front = rear = temp;
        else
        {
            rear.next = temp;
            rear = temp;
        }
    }

    public void Dequeue()
    {
        if (front == null)
            Console.WriteLine("Empty");
        else
        {
            Console.WriteLine("Deleted: " + front.data);
            front = front.next;
        }
    }

    static void Main()
    {
        QueueLL q = new QueueLL();
        q.Enqueue(10); q.Enqueue(20);
        q.Dequeue();
    }
}