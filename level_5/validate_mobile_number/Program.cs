using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string mobile = "9876543210";

        if (Regex.IsMatch(mobile, @"^[0-9]{10}$"))
            Console.WriteLine("Valid Mobile Number");
        else
            Console.WriteLine("Invalid Mobile Number");
    }
}