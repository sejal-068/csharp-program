using System;

class Program
{
    static void Main()
    {
        int binary = 1011;
        int decimalNum = 0, baseVal = 1;

        while (binary > 0)
        {
            int lastDigit = binary % 10;
            decimalNum += lastDigit * baseVal;
            baseVal *= 2;
            binary /= 10;
        }

        Console.WriteLine("Decimal = " + decimalNum);
    }
}