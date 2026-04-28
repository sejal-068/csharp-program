using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string str = "the quick brown fox jumps over the lazy dog";
        str = str.ToLower();

        bool isPangram = str.Where(char.IsLetter).Distinct().Count() == 26;

        if (isPangram)
            Console.WriteLine("Pangram");
        else
            Console.WriteLine("Not Pangram");
    }
}