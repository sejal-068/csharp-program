using System;

class SumOfDigit
{
    static int Main()
    {
        Console.Write("Enter the value of n :");
        int n= int.Parse(Console.ReadLine());
        int sum=0;

        while(n != 0)
        {
            int digit = n%10;
            sum += digit;
            n=n/10;
        }
        Console.WriteLine("Sum of digits: " + sum);
        return 0;
    }
}