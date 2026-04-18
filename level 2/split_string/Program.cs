using System;

class Program
{
    static void Main()
    {
        string str = "Hello world from C#";
        string[] words = str.Split(' ');

        foreach (string word in words)
            Console.WriteLine(word);
    }
}