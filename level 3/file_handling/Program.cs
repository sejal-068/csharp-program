using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "test.txt";

        File.WriteAllText(path, "Hello File");
        string content = File.ReadAllText(path);

        Console.WriteLine(content);
    }
}