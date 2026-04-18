using System;

class Program
{
    static void Main()
    {
        string str = "Hello world from C#";
        int count = str.Split(' ').Length;

        Console.WriteLine("Word count: " + count);
    }
}