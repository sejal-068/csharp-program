using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Hello");
        list.Add(3.5);

        foreach (var item in list)
            Console.WriteLine(item);
    }
}