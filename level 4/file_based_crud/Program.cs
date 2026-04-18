using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "data.txt";

        // Create
        File.WriteAllText(path, "Hello");

        // Read
        Console.WriteLine(File.ReadAllText(path));

        // Update
        File.AppendAllText(path, "\nUpdated");

        // Delete
        File.Delete(path);
    }
}