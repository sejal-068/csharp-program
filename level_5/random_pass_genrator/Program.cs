using System;

class Program
{
    static void Main()
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random rnd = new Random();

        string password = "";

        for (int i = 0; i < 8; i++)
        {
            password += chars[rnd.Next(chars.Length)];
        }

        Console.WriteLine("Password: " + password);
    }
}