using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.Delete("moved.txt");
        Console.WriteLine("File deleted");
    }
}