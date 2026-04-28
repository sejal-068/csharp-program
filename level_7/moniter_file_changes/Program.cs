using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileSystemWatcher watcher = new FileSystemWatcher(".");
        watcher.NotifyFilter = NotifyFilters.LastWrite;

        watcher.Changed += (s, e) =>
        {
            Console.WriteLine($"File changed: {e.Name}");
        };

        watcher.EnableRaisingEvents = true;

        Console.ReadLine(); // keep running
    }
}