using System;

class StackArray
{
    int[] stack = new int[5];
    int top = -1;

    public void Push(int x)
    {
        if (top == stack.Length - 1)
            Console.WriteLine("Overflow");
        else
            stack[++top] = x;
    }

    public void Pop()
    {
        if (top == -1)
            Console.WriteLine("Underflow");
        else
            Console.WriteLine("Popped: " + stack[top--]);
    }

    public void Display()
    {
        for (int i = top; i >= 0; i--)
            Console.Write(stack[i] + " ");
    }

    static void Main()
    {
        StackArray s = new StackArray();
        s.Push(10); s.Push(20); s.Push(30);
        s.Pop();
        s.Display();
    }
}