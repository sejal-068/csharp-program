using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Random rnd = new Random();

        for (int i = arr.Length - 1; i > 0; i--)
        {
            int j = rnd.Next(i + 1);

            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        Console.WriteLine("Shuffled Array:");
        foreach (int i in arr)
            Console.Write(i + " ");
    }
}