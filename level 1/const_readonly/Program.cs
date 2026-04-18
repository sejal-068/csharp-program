using System;

class Demo
{
    // Constant (fixed at compile-time)
    const double PI = 3.14159;

    // Readonly variable (can be assigned at runtime)
    readonly int number;

    // Constructor to initialize readonly variable
    public Demo(int value)
    {
        number = value;
    }

    void Display()
    {
        Console.WriteLine("Constant PI = " + PI);
        Console.WriteLine("Readonly number = " + number);
    }

    static void Main()
    {
        Demo obj1 = new Demo(10);
        obj1.Display();

        Demo obj2 = new Demo(20);
        obj2.Display();
    }
}