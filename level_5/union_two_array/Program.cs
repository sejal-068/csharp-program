using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 2, 3, 4 };

        HashSet<int> set = new HashSet<int>();

        foreach (int i in arr1)
            set.Add(i);

        foreach (int i in arr2)
            set.Add(i);

        Console.WriteLine("Union:");
        foreach (int i in set)
            Console.Write(i + " ");
    }
}