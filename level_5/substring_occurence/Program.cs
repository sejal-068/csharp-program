using System;

class Program
{
    static void Main()
    {
        string str = "banana";
        string sub = "an";
        int count = 0;

        for (int i = 0; i <= str.Length - sub.Length; i++)
        {
            if (str.Substring(i, sub.Length) == sub)
                count++;
        }

        Console.WriteLine("Occurrences: " + count);
    }
}