using System;
using System.IO;

class Program
{
    static void Main()
    {
        string keyword = "hello";

        foreach (var line in File.ReadLines("data.txt"))
        {
            if (line.Contains(keyword))
                Console.WriteLine(line);
        }
    }
}