using System;

class Account
{
    public int Balance = 1000;

    public void Deposit(int amount)
    {
        Balance += amount;
    }

    public void Withdraw(int amount)
    {
        Balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        Account acc = new Account();
        acc.Deposit(500);
        acc.Withdraw(200);

        Console.WriteLine("Balance: " + acc.Balance);
    }
}