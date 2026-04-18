using System;

class Invoice
{
    public void Calculate()
    {
        Console.WriteLine("Calculating invoice");
    }
}

class InvoicePrinter
{
    public void Print()
    {
        Console.WriteLine("Printing invoice");
    }
}

class Program
{
    static void Main()
    {
        Invoice inv = new Invoice();
        inv.Calculate();

        InvoicePrinter printer = new InvoicePrinter();
        printer.Print();
    }
}