using System;

class Program
{
    static void Main()
    {
        int num = 25;
        int square = num * num;

        if (square.ToString().EndsWith(num.ToString()))
            Console.WriteLine("Automorphic Number");
        else
            Console.WriteLine("Not Automorphic Number");
    }
}