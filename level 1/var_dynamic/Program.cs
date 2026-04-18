using System;

class Program
{
    static void Main()
    {
        var a = 10;        // compile-time type
        dynamic b = "Hello";

        Console.WriteLine("var a = " + a);

        b = 20;  // allowed
        Console.WriteLine("dynamic b = " + b);
    }
}