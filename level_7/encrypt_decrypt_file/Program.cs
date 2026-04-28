using System;
using System.IO;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("data.txt");

        char key = 'K';
        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
            result[i] = (char)(text[i] ^ key);

        File.WriteAllText("encrypted.txt", new string(result));

        Console.WriteLine("Encrypted");
    }
}