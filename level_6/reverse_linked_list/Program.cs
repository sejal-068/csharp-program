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
        Node head = new Node { data = 1, next = new Node { data = 2, next = new Node { data = 3 } } };

        Node prev = null, current = head;

        while (current != null)
        {
            Node next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        while (prev != null)
        {
            Console.Write(prev.data + " ");
            prev = prev.next;
        }
    }
}