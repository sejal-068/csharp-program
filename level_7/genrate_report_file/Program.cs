using System;
using System.IO;

class Program
{
    static void Main()
    {
        int count = 0;

        foreach (var line in File.ReadLines("data.txt"))
            count++;

        File.WriteAllText("report.txt", "Total lines: " + count);

        Console.WriteLine("Report generated");
    }
}