using System;
using System.Threading;

class Program
{
    static object lockObj = new object();

    static void Print()
    {
        lock (lockObj)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + ": " + i);
            }
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Print);
        Thread t2 = new Thread(Print);

        t1.Start();
        t2.Start();
    }
}