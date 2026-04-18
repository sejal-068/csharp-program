using System;

class Program
{
    static void CheckAge(int age)
    {
        if (age < 18)
            throw new Exception("Not eligible");
        else
            Console.WriteLine("Eligible");
    }

    static void Main()
    {
        try
        {
            CheckAge(16);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}