using System;

class Program
{
    static void Main()
    {
        string str = "hello world";
        int count = 0;

        foreach (char c in str.ToLower())
        {
            if (char.IsLetter(c) && !"aeiou".Contains(c))
                count++;
        }

        Console.WriteLine("Consonants: " + count);
    }
}