using System;

class Deque
{
    int[] dq = new int[5];
    int front = -1, rear = -1;

    public void InsertFront(int x)
    {
        if (front == 0)
            Console.WriteLine("No space");
        else
        {
            if (front == -1) front = rear = 0;
            else front--;
            dq[front] = x;
        }
    }

    public void InsertRear(int x)
    {
        if (rear == dq.Length - 1)
            Console.WriteLine("No space");
        else
        {
            if (rear == -1) front = rear = 0;
            else rear++;
            dq[rear] = x;
        }
    }

    public void Display()
    {
        for (int i = front; i <= rear; i++)
            Console.Write(dq[i] + " ");
    }

    static void Main()
    {
        Deque d = new Deque();
        d.InsertRear(10);
        d.InsertFront(5);
        d.Display();
    }
}