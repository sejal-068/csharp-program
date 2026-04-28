using System;

class Node
{
    public int data;
    public Node next;
}

class StackLL
{
    Node top = null;

    public void Push(int x)
    {
        Node temp = new Node { data = x };
        temp.next = top;
        top = temp;
    }

    public void Pop()
    {
        if (top == null)
            Console.WriteLine("Empty");
        else
        {
            Console.WriteLine("Popped: " + top.data);
            top = top.next;
        }
    }

    static void Main()
    {
        StackLL s = new StackLL();
        s.Push(10); s.Push(20);
        s.Pop();
    }
}