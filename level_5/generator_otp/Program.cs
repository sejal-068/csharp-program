using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int otp = rnd.Next(1000, 9999);

        Console.WriteLine("OTP: " + otp);
    }
}