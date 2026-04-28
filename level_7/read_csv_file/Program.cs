using System;
using System.IO;

class Program
{
    static void Main()
    {
        foreach (var line in File.ReadAllLines("data.csv"))
        {
            string[] values = line.Split(',');
            Console.WriteLine(string.Join(" | ", values));
        }
    }
}