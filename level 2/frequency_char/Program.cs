using System;

class Program
{
    static void Main()
    {
        string str = "hello";

        foreach (char ch in str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (ch == c)
                    count++;
            }
            Console.WriteLine(ch + " : " + count);
        }
    }
}