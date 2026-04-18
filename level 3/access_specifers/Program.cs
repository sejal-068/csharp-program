using System;

class Demo
{
    public int a = 1;
    private int b = 2;

    public void Show()
    {
        Console.WriteLine("Public: " + a);
        Console.WriteLine("Private: " + b);
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        Console.WriteLine(d.a);
        d.Show();
    }
}