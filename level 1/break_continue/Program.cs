
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Break Example:");

        // Break example
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                break;   // exits loop when i = 5
            }
            Console.WriteLine(i);
        }

        Console.WriteLine("\nContinue Example:");

        // Continue example
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                continue;   // skips 5
            }
            Console.WriteLine(i);
        }
    }
}