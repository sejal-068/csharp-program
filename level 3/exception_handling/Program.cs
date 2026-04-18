using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10, b = 0;
            int c = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Finally block executed");
        }
    }
}