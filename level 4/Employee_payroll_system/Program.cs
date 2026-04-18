using System;

class Employee
{
    public int Salary;
    public int Bonus;

    public int Total()
    {
        return Salary + Bonus;
    }
}

class Program
{
    static void Main()
    {
        Employee e = new Employee { Salary = 20000, Bonus = 5000 };
        Console.WriteLine("Total Salary: " + e.Total());
    }
}