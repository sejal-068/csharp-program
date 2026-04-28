using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40 };
        int key = 30;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
            {
                Console.WriteLine("Found at index " + i);
                return;
            }
        }

        Console.WriteLine("Not Found");
    }
}