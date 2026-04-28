using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int n = arr.Length;

        int last = arr[n - 1];

        for (int i = n - 1; i > 0; i--)
            arr[i] = arr[i - 1];

        arr[0] = last;

        Console.WriteLine("Right Rotated Array:");
        foreach (int i in arr)
            Console.Write(i + " ");
    }
}