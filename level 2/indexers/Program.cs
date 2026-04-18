using System;

class Sample
{
    private int[] arr = new int[5];

    public int this[int index]
    {
        get { return arr[index]; }
        set { arr[index] = value; }
    }
}

class Program
{
    static void Main()
    {
        Sample s = new Sample();
        s[0] = 10;
        Console.WriteLine(s[0]);
    }
}