using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.Copy("source.txt", "copy.txt", true);
        Console.WriteLine("File copied");
    }
}