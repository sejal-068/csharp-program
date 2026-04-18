using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

        var unique = arr.Distinct();

        Console.WriteLine("Array after removing duplicates:");
        foreach (var num in unique)
        {
            Console.Write(num + " ");
        }
    }
}