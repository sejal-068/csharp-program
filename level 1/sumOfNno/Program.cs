using System;
 class SumofDigit
{
    static int sumOfDigit(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        int sum= n +sumOfDigit(n-1);
        return sum;
    }


    static void Main()
    {
        Console.Write("entrt the value of n:");
        int n= int.Parse(Console.ReadLine());
        Console.WriteLine($"sum of digit {n} is :{sumOfDigit(n)}");
    }
}