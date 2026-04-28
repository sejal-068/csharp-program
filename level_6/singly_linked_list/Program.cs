using System;

class Node
{
    public int data;
    public Node next;
}

class Program
{
    static void Main()
    {
        Node head = new Node { data = 10 };
        head.next = new Node { data = 20 };
        head.next.next = new Node { data = 30 };

        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
    }
}