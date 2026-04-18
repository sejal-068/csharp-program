using System;

class Program
{
    static void Main()
    {
        string str = "madam";
        string rev = "";

        foreach (char ch in str)
        {
            rev = ch + rev;
        }

        if (str == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}