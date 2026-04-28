using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str = "programming";
        HashSet<char> set = new HashSet<char>();
        string result = "";

        foreach (char c in str)
        {
            if (!set.Contains(c))
            {
                set.Add(c);
                result += c;
            }
        }

        Console.WriteLine("Without duplicates: " + result);
    }
}