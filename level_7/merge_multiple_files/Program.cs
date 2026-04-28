using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] files = { "file1.txt", "file2.txt" };

        using (StreamWriter sw = new StreamWriter("merged.txt"))
        {
            foreach (var file in files)
            {
                foreach (var line in File.ReadLines(file))
                    sw.WriteLine(line);
            }
        }

        Console.WriteLine("Files merged");
    }
}