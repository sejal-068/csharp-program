using System;
using System.Collections.Generic;

class Item
{
    public string Name;
    public int Quantity;
}

class Program
{
    static void Main()
    {
        List<Item> items = new List<Item>();

        items.Add(new Item { Name = "Pen", Quantity = 10 });

        foreach (var i in items)
        {
            Console.WriteLine(i.Name + " " + i.Quantity);
        }
    }
}