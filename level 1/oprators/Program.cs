using System;

class OperatorsDemo
{
    static void Main()
    {
        int a = 10, b = 5;

        // Arithmetic Operators
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));

        // Relational Operators
        Console.WriteLine("\nRelational Operators:");
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));
        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a != b: " + (a != b));

        // Logical Operators
        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine("(a > b && a != b): " + (a > b && a != b));
        Console.WriteLine("(a < b || a == 10): " + (a < b || a == 10));
        Console.WriteLine("!(a > b): " + !(a > b));

        // Assignment Operators
        Console.WriteLine("\nAssignment Operators:");
        int c = a;
        Console.WriteLine("c = a: " + c);

        c += b;
        Console.WriteLine("c += b: " + c);

        c -= b;
        Console.WriteLine("c -= b: " + c);

        // Unary Operators
        Console.WriteLine("\nUnary Operators:");
        Console.WriteLine("a++: " + (a++));
        Console.WriteLine("After a++: " + a);
        Console.WriteLine("++b: " + (++b));
    }
}