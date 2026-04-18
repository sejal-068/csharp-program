using System;

class Program
{
    static void Main()
    {
        var person = (Id: 1, Name: "Sejal");

        Console.WriteLine("ID: " + person.Id);
        Console.WriteLine("Name: " + person.Name);
    }
}