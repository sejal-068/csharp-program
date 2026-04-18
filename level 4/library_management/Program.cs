using System;
using System.Collections.Generic;

class Book
{
    public int Id;
    public string Title;
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>();

        books.Add(new Book { Id = 1, Title = "C# Basics" });

        foreach (var b in books)
        {
            Console.WriteLine(b.Id + " " + b.Title);
        }
    }
}