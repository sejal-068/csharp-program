using System;

class maximumOftwo
{
    static int max(int a, int b)
    {
        if(a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static void Main()
    {
        Console.Write("Enter a:");
        int a= int.Parse(Console.ReadLine());

        Console.Write("Enter b:");
        int b= int.Parse(Console.ReadLine());
        Console.WriteLine("maximum of a and b is:" +max(a,b));
    }
}