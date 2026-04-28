using System;

class Program
{
    static void Main()
    {
        string str = "I love programming in CSharp";
        string[] words = str.Split(' ');

        string longest = "";

        foreach (string word in words)
        {
            if (word.Length > longest.Length)
                longest = word;
        }

        Console.WriteLine("Longest Word: " + longest);
    }
}