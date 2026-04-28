using System;

class Program
{
    static void Main()
    {
        int num = 9;
        int square = num * num;
        int sum = 0;

        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }

        if (sum == num)
            Console.WriteLine("Neon Number");
        else
            Console.WriteLine("Not Neon Number");
    }
}