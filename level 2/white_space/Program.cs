using System;

class Program
{
    static void Main()
    {
        string str = "Hello World C#";
        string result = str.Replace(" ", "");

        Console.WriteLine("Without spaces: " + result);
    }
}