using System;

class Program
{
    static void Main()
    {
        string str = "Hello World";
        int count = 0;

        foreach (char ch in str.ToLower())
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                count++;
            }
        }

        Console.WriteLine("Number of vowels: " + count);
    }
}