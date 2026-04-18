using System;
using Moq;

interface IService
{
    int GetData();
}

class Program
{
    static void Main()
    {
        var mock = new Mock<IService>();
        mock.Setup(x => x.GetData()).Returns(10);

        Console.WriteLine(mock.Object.GetData());
    }
}