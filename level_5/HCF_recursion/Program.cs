using System;

class Program
{
    static int HCF(int a, int b)
    {
        if (b == 0)
            return a;
        return HCF(b, a % b);
    }

    static void Main()
    {
        int a = 12, b = 18;
        Console.WriteLine("HCF = " + HCF(a, b));
    }
}