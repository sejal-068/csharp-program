using System;

class Program
{
    static void Main()
    {
        int n = 3;
        int[,] magic = new int[n, n];

        int i = 0, j = n / 2;

        for (int num = 1; num <= n * n; num++)
        {
            magic[i, j] = num;

            int newi = (i - 1 + n) % n;
            int newj = (j + 1) % n;

            if (magic[newi, newj] != 0)
                i = (i + 1) % n;
            else
            {
                i = newi;
                j = newj;
            }
        }

        // Print
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
                Console.Write(magic[i, j] + "\t");
            Console.WriteLine();
        }
    }
}