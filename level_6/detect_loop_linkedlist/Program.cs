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
        Node head = new Node { data = 1 };
        head.next = new Node { data = 2 };
        head.next.next = head; // loop

        Node slow = head, fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
            {
                Console.WriteLine("Loop Detected");
                return;
            }
        }

        Console.WriteLine("No Loop");
    }
}