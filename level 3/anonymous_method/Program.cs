using System;

delegate void MyDelegate(string msg);

class Program
{
    static void Main()
    {
        MyDelegate d = delegate (string msg)
        {
            Console.WriteLine(msg);
        };

        d("Hello Anonymous Method");
    }
}