using System;

class Program
{
    static void Main()
    {
        string str = "Hello";
        str.Concat(" World"); // does not change original string

        Console.WriteLine("Original: " + str);

        str = str + " World"; // new string created
        Console.WriteLine("Modified: " + str);
    }
}