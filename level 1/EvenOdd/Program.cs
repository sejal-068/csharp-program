using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer:");
        int num= int.Parse(Console.ReadLine());
        if (num %2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}