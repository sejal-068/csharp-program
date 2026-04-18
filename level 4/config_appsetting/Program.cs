using System;
using Microsoft.Extensions.Configuration;
using System.IO;

class Program
{
    static void Main()
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        Console.WriteLine(config["AppSettings:Name"]);
    }
}