using System;

class Palindrome
{
    static int PalindromeCheck(string str)
    {
      

        int i=0;
        int j= str.Length-1;
        while (i < j)
        {
            if (str[i] == str[j])
            {
                i++;
                j--;
            }
            else
           {           
                return 0; // Not a palindrome
            }
        }
        return 1; // Is a palindrome
    }
    static void Main()
    {
        Console.Write("enter the string :");
        string str = Console.ReadLine();
        if(PalindromeCheck(str) == 1)
        {
            Console.WriteLine($"{str} is a palindrome.");

        }
        else
        {
            Console.WriteLine($"{str} is not a palindrome");
        }
    }
}