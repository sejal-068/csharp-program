using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 5, 40, 30 };
        Array.Sort(arr);
        Console.WriteLine("Second Largest: " + arr[arr.Length - 2]);
    }
}