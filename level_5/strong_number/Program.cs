using System;

class Program
{
    static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;
        return fact;
    }

    static void Main()
    {
        int num = 145, sum = 0, temp = num;

        while (num > 0)
        {
            int digit = num % 10;
            sum += Factorial(digit);
            num /= 10;
        }

        if (sum == temp)
            Console.WriteLine("Strong Number");
        else
            Console.WriteLine("Not Strong Number");
    }
}