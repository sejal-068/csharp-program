using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await DoWork();
    }

    static async Task DoWork()
    {
        await Task.Delay(1000);
        Console.WriteLine("Task completed");
    }
}