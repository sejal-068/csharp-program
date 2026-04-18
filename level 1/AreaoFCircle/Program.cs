using System;
class AreaOfCircle
{
    static void Main()
    {
        Console.Write("enter the value of radius :");
        double r= double.Parse(Console.ReadLine());
        double area = 3.14 *r *r;
        Console.WriteLine($"area of circle is : {area}");
    }
}