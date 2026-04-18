using System;

interface IA
{
    void MethodA();
}

interface IB
{
    void MethodB();
}

class Demo : IA, IB
{
    public void MethodA()
    {
        Console.WriteLine("Method A");
    }

    public void MethodB()
    {
        Console.WriteLine("Method B");
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.MethodA();
        d.MethodB();
    }
}