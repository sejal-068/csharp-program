using System;

class Node
{
    public int data;
    public Node prev, next;
}

class Program
{
    static void Main()
    {
        Node head = new Node { data = 10 };
        Node second = new Node { data = 20 };

        head.next = second;
        second.prev = head;

        Console.WriteLine(head.data + " <-> " + second.data);
    }
}