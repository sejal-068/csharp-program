using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4 };

        int sum = arr.Aggregate((a, b) => a + b);

        Console.WriteLine("Sum: " + sum);
    }
}