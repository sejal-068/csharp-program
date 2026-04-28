using System;

class Program
{
    static bool IsPalindrome(string s)
    {
        int l = 0, r = s.Length - 1;
        while (l < r)
        {
            if (s[l] != s[r])
                return false;
            l++; r--;
        }
        return true;
    }

    static void Main()
    {
        string str = "babad";
        string longest = "";

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j <= str.Length; j++)
            {
                string sub = str.Substring(i, j - i);

                if (IsPalindrome(sub) && sub.Length > longest.Length)
                    longest = sub;
            }
        }

        Console.WriteLine("Longest Palindrome: " + longest);
    }
}