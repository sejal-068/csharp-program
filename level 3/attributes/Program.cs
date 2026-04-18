using System;

[Obsolete("This method is old")]
class Demo
{
    public void Show()
    {
        Console.WriteLine("Old method");
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.Show();
    }
}