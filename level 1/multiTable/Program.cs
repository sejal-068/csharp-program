using System;
class MultiTable
{
    static void Main()
    {
        Console.Write("enter the value of n and :");
        int n= int.Parse(Console.ReadLine());

        for(int i= 1; i<=10; i++)
        {
            Console.WriteLine($"{n} * {i} = {n*i}");
        }
    }
}
