using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 3, 2, 5, 4 };
        Array.Sort(arr);

        int n = arr.Length;
        double median;

        if (n % 2 == 0)
            median = (arr[n / 2 - 1] + arr[n / 2]) / 2.0;
        else
            median = arr[n / 2];

        Console.WriteLine("Median = " + median);
    }
}