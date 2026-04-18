using System;

static class Extension
{
    public static int Square(this int num)
    {
        return num * num;
    }
}

class Program
{
    static void Main()
    {
        int x = 5;
        Console.WriteLine(x.Square());
    }
}