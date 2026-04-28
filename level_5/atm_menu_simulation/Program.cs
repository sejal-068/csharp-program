using System;

class Program
{
    static void Main()
    {
        int balance = 1000;
        int choice;

        do
        {
            Console.WriteLine("\n1. Check Balance\n2. Deposit\n3. Withdraw\n4. Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Balance: " + balance);
                    break;

                case 2:
                    Console.Write("Enter amount: ");
                    int dep = int.Parse(Console.ReadLine());
                    balance += dep;
                    break;

                case 3:
                    Console.Write("Enter amount: ");
                    int wd = int.Parse(Console.ReadLine());
                    if (wd <= balance)
                        balance -= wd;
                    else
                        Console.WriteLine("Insufficient Balance");
                    break;
            }

        } while (choice != 4);
    }
}