
using System;

class Program
{
    static void Main()
    {
        int baseNum, exponent;
        int result = 1;

        Console.Write("Enter base number: ");
        baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter exponent: ");
        exponent = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= exponent; i++)
        {
            result = result * baseNum;
        }

        Console.WriteLine("Result = " + result);
    }
}