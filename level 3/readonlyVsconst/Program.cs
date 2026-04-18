using System;

class Demo
{
    public const int x = 10;        // compile-time constant
    public readonly int y;          // runtime constant

    public Demo()
    {
        y = 20;
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        Console.WriteLine("Const: " + Demo.x);
        Console.WriteLine("Readonly: " + d.y);
    }
}