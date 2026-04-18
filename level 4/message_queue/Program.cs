// Install RabbitMQ.Client

using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory() { HostName = "localhost" };

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "test", durable: false);

var body = Encoding.UTF8.GetBytes("Hello MQ");

channel.BasicPublish("", "test", null, body);

Console.WriteLine("Message Sent");