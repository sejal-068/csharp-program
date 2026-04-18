
using System;

class Program
{
    static void Main()
    {
        int days = 800;
        int years = days / 365;
        int months = (days % 365) / 30;
        int remainingDays = (days % 365) % 30;

        Console.WriteLine("Years = " + years);
        Console.WriteLine("Months = " + months);
        Console.WriteLine("Days = " + remainingDays);
    }
}