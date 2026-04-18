
using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine("Current Date & Time: " + now);
        Console.WriteLine("Date: " + now.Date);
        Console.WriteLine("Time: " + now.TimeOfDay);
        Console.WriteLine("Year: " + now.Year);
        Console.WriteLine("Month: " + now.Month);
        Console.WriteLine("Day: " + now.Day);
    }
}