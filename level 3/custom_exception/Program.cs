using System;

class MyException : Exception
{
    public MyException(string msg) : base(msg) { }
}

class Program
{
    static void Main()
    {
        try
        {
            throw new MyException("Custom Exception Occurred");
        }
        catch (MyException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}