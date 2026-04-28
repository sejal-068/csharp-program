using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 2, 3, 4 };

        HashSet<int> set1 = new HashSet<int>(arr1);

        Console.WriteLine("Intersection:");
        foreach (int i in arr2)
        {
            if (set1.Contains(i))
                Console.Write(i + " ");
        }
    }
}