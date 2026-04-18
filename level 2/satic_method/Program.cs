using System;

class Program
{
    static void Greet()
    {
        Console.WriteLine("Hello from static method");
    }

    static void Main()
    {
        Greet(); // called without object
    }
}