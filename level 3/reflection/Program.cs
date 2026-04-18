using System;
using System.Reflection;

class Demo
{
    public void Show() { }
}

class Program
{
    static void Main()
    {
        Type t = typeof(Demo);

        foreach (var method in t.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}