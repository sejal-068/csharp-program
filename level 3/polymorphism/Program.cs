using System;

class Program
{
    static void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    static void Add(double a, double b)
    {
        Console.WriteLine(a + b);
    }

    static void Main()
    {
        Add(2, 3);
        Add(2.5, 3.5);
    }
}