using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int key = 30;

        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == key)
            {
                Console.WriteLine("Found at index " + mid);
                return;
            }
            else if (arr[mid] < key)
                left = mid + 1;
            else
                right = mid - 1;
        }

        Console.WriteLine("Not Found");
    }
}