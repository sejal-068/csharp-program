using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 3, 3, 4 };
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        int mode = arr[0], maxCount = 0;

        foreach (var item in freq)
        {
            if (item.Value > maxCount)
            {
                maxCount = item.Value;
                mode = item.Key;
            }
        }

        Console.WriteLine("Mode = " + mode);
    }
}