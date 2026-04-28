using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("1. Candidate A\n2. Candidate B");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                Console.WriteLine("You voted for A");
            else if (choice == 2)
                Console.WriteLine("You voted for B");
            else
                Console.WriteLine("Invalid choice");
        }
        else
        {
            Console.WriteLine("Not eligible to vote");
        }
    }
}