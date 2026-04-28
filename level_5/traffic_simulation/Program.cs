using System;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Red Light - STOP");
            Thread.Sleep(2000);

            Console.WriteLine("Yellow Light - READY");
            Thread.Sleep(2000);

            Console.WriteLine("Green Light - GO");
            Thread.Sleep(2000);
        }
    }
}