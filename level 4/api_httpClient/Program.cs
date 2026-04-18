using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        HttpClient client = new HttpClient();
        string data = await client.GetStringAsync("https://api.github.com");

        Console.WriteLine(data);
    }
}