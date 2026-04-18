using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        Span<int> span = arr;
        span[0] = 100; // modifies original array

        ReadOnlySpan<int> readOnlySpan = arr;

        Console.WriteLine("Span modified array:");
        foreach (var i in span)
            Console.Write(i + " ");

        Console.WriteLine("\nReadOnlySpan:");
        foreach (var i in readOnlySpan)
            Console.Write(i + " ");
    }
}