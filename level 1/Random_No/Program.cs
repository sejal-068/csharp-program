
using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("Random Numbers:");

        for (int i = 1; i <= 5; i++)
        {
            int number = rand.Next(1, 101); // generates number between 1 to 100
            Console.WriteLine(number);
        }
    }
}