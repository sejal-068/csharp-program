using System;

class Program
{
    static void Main()
    {
        int a = 10; // stored in stack

        int[] arr = new int[3]; // stored in heap

        Console.WriteLine("Before GC");
        
        arr = null; // eligible for garbage collection

        GC.Collect(); // force garbage collection

        Console.WriteLine("After GC");
    }
}