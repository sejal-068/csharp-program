using System;

class Program
{
    static void Main()
    {
        string correctPassword = "1234";

        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Enter Password: ");
            string input = Console.ReadLine();

            if (input == correctPassword)
            {
                Console.WriteLine("Login Successful");
                return;
            }
            else
            {
                Console.WriteLine("Wrong Password");
            }
        }

        Console.WriteLine("Account Locked");
    }
}