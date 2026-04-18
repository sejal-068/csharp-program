using System;

class Program
{
    static void Main()
    {
        // Value type
        int a = 10;
        int b = a;
        b = 20;

        Console.WriteLine("Value Type:");
        Console.WriteLine("a = " + a); // unchanged
        Console.WriteLine("b = " + b);

        // Reference type
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;
        arr2[0] = 100;

        Console.WriteLine("\nReference Type:");
        Console.WriteLine(arr1[0]); // changed
    }
}