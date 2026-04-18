using System;
using System.Collections.Generic;

class Product
{
    public string Name;
    public int Price;
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();

        products.Add(new Product { Name = "Laptop", Price = 50000 });

        foreach (var p in products)
        {
            Console.WriteLine(p.Name + " " + p.Price);
        }
    }
}