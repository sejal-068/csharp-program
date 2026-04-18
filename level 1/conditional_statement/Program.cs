using System;

class Program
{
    static void Main()
    {
        int num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        // if statement
        if (num > 0)
        {
            Console.WriteLine("Number is Positive");
        }

        // if-else statement
        if (num % 2 == 0)
        {
            Console.WriteLine("Number is Even");
        }
        else
        {
            Console.WriteLine("Number is Odd");
        }

        // else-if ladder
        if (num > 0)
        {
            Console.WriteLine("Positive Number");
        }
        else if (num < 0)
        {
            Console.WriteLine("Negative Number");
        }
        else
        {
            Console.WriteLine("Number is Zero");
        }

        // switch statement
        Console.Write("\nEnter a day number (1-3): ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;

            case 2:
                Console.WriteLine("Tuesday");
                break;

            case 3:
                Console.WriteLine("Wednesday");
                break;

            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}