using System;

class Program
{
    static void UseOut(out int x)
    {
        x = 10; // must assign before use
    }

    static void UseRef(ref int y)
    {
        y = y + 5; // must be initialized before passing
    }

    static void Main()
    {
        int a;
        UseOut(out a);
        Console.WriteLine("Out value: " + a);

        int b = 5;
        UseRef(ref b);
        Console.WriteLine("Ref value: " + b);
    }
}