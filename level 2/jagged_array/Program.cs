using System;

class Program
{
    static void Main()
    {
        int[][] jagged = new int[2][];
        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };

        foreach (var row in jagged)
        {
            foreach (var val in row)
                Console.Write(val + " ");
            Console.WriteLine();
        }
    }
}