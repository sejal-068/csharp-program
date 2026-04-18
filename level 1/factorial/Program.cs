using System;

class Factorial
{

   static int factorial(int n)
    {
     if(n==0 || n == 1)
        {
            return 1;
        }  
        int fn= n*factorial(n-1);
        return fn; 
    }

static void Main()
{
    Console.Write("enter the value of n :");
    int n=int .Parse(Console.ReadLine());
    Console.WriteLine($"factorial of {n} is : {factorial(n)}");
}

}