using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] data =
        {
            "Name,Age",
            "Sejal,20",
            "Rahul,22"
        };

        File.WriteAllLines("data.csv", data);
        Console.WriteLine("CSV written");
    }
}