 using System;

class Program
{
    static void Main()
    {
        // Implicit Casting (Automatic)
        int num = 10;
        double implicitCast = num;   // int → double

        Console.WriteLine("Implicit Casting:");
        Console.WriteLine("Integer value = " + num);
        Console.WriteLine("Converted to double = " + implicitCast);

        // Explicit Casting (Manual)
        double value = 9.78;
        int explicitCast = (int)value;   // double → int

        Console.WriteLine("\nExplicit Casting:");
        Console.WriteLine("Double value = " + value);
        Console.WriteLine("Converted to int = " + explicitCast);

        // Using Convert class
        string str = "123";
        int converted = Convert.ToInt32(str);

        Console.WriteLine("\nUsing Convert Class:");
        Console.WriteLine("String value = " + str);
        Console.WriteLine("Converted to int = " + converted);
    }
}