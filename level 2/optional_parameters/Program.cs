using System;

class Program
{
    static void Display(string name = "Guest")
    {
        Console.WriteLine("Hello " + name);
    }

    static void Main()
    {
        Display("Sejal");
        Display(); // uses default value
    }
}