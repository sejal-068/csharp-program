using System;

delegate void MyDelegate(string msg);

class Program
{
    static void Show(string msg)
    {
        Console.WriteLine(msg);
    }

    static void Main()
    {
        MyDelegate d = Show;
        d("Hello Delegate");
    }
}