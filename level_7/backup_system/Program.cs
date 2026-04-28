using System;
using System.IO;

class Program
{
    static void Main()
    {
        string source = "data.txt";
        string backup = "backup_" + DateTime.Now.Ticks + ".txt";

        File.Copy(source, backup);
        Console.WriteLine("Backup created");
    }
}