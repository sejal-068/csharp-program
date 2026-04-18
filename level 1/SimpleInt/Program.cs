using System;
class SimpleIntrest
{

    static double simpleIntrest(double p, double r, double t)
    {
        double si= (p * r *t)/ 100;
        return si;
    }
    static void Main()
    {
        Console.Write("Enter original amount:");
        double p = double.Parse(Console.ReadLine());

        Console.Write("Enter rate of interest :");
        double r= double.Parse(Console.ReadLine());

        Console.Write("Enter time period in years:"); 
        double t = double.Parse(Console.ReadLine());
        double simple = simpleIntrest(p, r, t);
        Console.WriteLine("Simple Interest is: {0}", simple);
        }
}