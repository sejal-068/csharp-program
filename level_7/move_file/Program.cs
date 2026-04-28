using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.Move("copy.txt", "moved.txt");
        Console.WriteLine("File moved");
    }
}