using System;

class prime
{
    static void Main()
    {
        Console.Write("enter the value of n :");
        int n= int.Parse(Console.ReadLine());
        if (n == 2)
        {
            Console.WriteLine($"{n} is a prime number");

        }
        else if (n < 2)
        {
            Console.WriteLine($"{n} is not a prime number");
        }
        else
        {
            for(int i=2; i<=n; i++)
            {
                if( n%i != 0)
                {
                    Console.WriteLine($"{n} is a prime number");
                    break;
                }
                else
                {
                    Console.WriteLine($"{n} is not a prime number");
                }
                
            }
        }
    }
}
