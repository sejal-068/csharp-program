using System;

class Program
{
    static void Main()
    {
        string str = "aaabb";
        string result = "";

        int count = 1;

        for (int i = 0; i < str.Length; i++)
        {
            if (i < str.Length - 1 && str[i] == str[i + 1])
                count++;
            else
            {
                result += str[i] + count.ToString();
                count = 1;
            }
        }

        Console.WriteLine("Compressed: " + result);
    }
}