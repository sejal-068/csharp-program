using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "Aman", "Ankit", "Ravi", "Raj" };

        var groups = names.GroupBy(n => n[0]);

        foreach (var group in groups)
        {
            Console.WriteLine("Group: " + group.Key);
            foreach (var name in group)
            {
                Console.WriteLine(name);
            }
        }
    }
}