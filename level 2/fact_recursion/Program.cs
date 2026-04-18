using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
}