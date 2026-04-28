using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("data.txt");

        int partSize = 2;
        int fileCount = 0;

        for (int i = 0; i < lines.Length; i += partSize)
        {
            File.WriteAllLines($"part{fileCount}.txt",
                lines[i..Math.Min(i + partSize, lines.Length)]);
            fileCount++;
        }

        Console.WriteLine("File split");
    }
}