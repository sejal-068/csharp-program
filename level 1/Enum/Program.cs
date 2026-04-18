using System;

enum Days { Monday, Tuesday, Wednesday, Thursday, Friday }

class Program
{
    static void Main()
    {
        Days d = Days.Wednesday;
        Console.WriteLine("Day: " + d);
    }
}