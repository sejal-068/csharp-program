using System;

class CountNum
{
    static void Main()
    {
        Console.Write("enter the string :");
        string str = Console.ReadLine();
        int count =0;
        int n= str.Length;

        for(int i=0; i<str.Length; i++)
        {
            count++;
        }
        Console.WriteLine($"count of characters in the string is :{count}");
    }
}   