using System;
class AreaofRec
{
    static void Main()
    {
        Console.Write("enter the length of rectangle :");
        int l = int.Parse(Console.ReadLine());
        Console.Write("enter the breadth of rectangle :");
        int b= int.Parse(Console.ReadLine());
         int area = l *b;
         Console.WriteLine($"area of rectangle is :{area}");
    }
}