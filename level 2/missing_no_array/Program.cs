using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 5 };
        int n = 5;

        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;

        foreach (int num in arr)
            actualSum += num;

        Console.WriteLine("Missing number: " + (expectedSum - actualSum));
    }
}