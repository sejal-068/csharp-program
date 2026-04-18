using System;

class Program
{
    static void ShowDetails(string name, int age)
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }

    static void Main()
    {
        ShowDetails(age: 20, name: "Sejal"); // order changed
    }
}