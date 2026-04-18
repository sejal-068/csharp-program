using System;

class Fibonacci
{
    static int fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        if (n == 1)
        {
            return 1;
        }
        return fibonacci(n-1) + fibonacci(n-2);
    }
    static void Main()
    {
        Console.Write("enter the value of n :");
        int n= int.Parse(Console.ReadLine());
        for(int i=0 ; i<n ; i++)
        {
            Console.Write($"{fibonacci(i)} ");
        }
        
}
}