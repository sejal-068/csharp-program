using System;
using Microsoft.Extensions.DependencyInjection;

interface IMessage
{
    void Send();
}

class Email : IMessage
{
    public void Send() => Console.WriteLine("Email Sent");
}

class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection()
            .AddTransient<IMessage, Email>()
            .BuildServiceProvider();

        var service = serviceProvider.GetService<IMessage>();
        service.Send();
    }
}