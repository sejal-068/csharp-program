using System;

delegate void MyDelegate();

class Program
{
    static void Method1()
    {
        Console.WriteLine("Method 1");
    }

    static void Method2()
    {
        Console.WriteLine("Method 2");
    }

    static void Main()
    {
        MyDelegate d = Method1;
        d += Method2;

        d(); // calls both methods
    }
}