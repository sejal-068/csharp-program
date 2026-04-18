using System;

class Publisher
{
    public event Action Notify;

    public void RaiseEvent()
    {
        Notify?.Invoke();
    }
}

class Program
{
    static void Main()
    {
        Publisher p = new Publisher();
        p.Notify += () => Console.WriteLine("Event triggered");

        p.RaiseEvent();
    }
}