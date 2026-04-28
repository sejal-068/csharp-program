using System;
using System.IO;

class Program
{
    static void Main()
    {
        string log = DateTime.Now + " - User logged in";
        File.AppendAllText("log.txt", log + Environment.NewLine);
        Console.WriteLine("Log saved");
    }
}