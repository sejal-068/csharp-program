using System;

class Demo<T>
{
    public void Show(T value)
    {
        Console.WriteLine(value);
    }
}

class Program
{
    static void Main()
    {
        Demo<int> d1 = new Demo<int>();
        d1.Show(10);

        Demo<string> d2 = new Demo<string>();
        d2.Show("Hello");
    }
}