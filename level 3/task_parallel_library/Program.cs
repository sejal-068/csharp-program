using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Parallel.For(1, 4, i =>
        {
            Console.WriteLine("Parallel: " + i);
        });
    }
}