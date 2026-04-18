using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        HttpClient client = new HttpClient();
        string response = await client.GetStringAsync("https://localhost:5001/api/data");

        Console.WriteLine(response);
    }
}