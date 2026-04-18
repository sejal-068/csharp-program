using System;

class CompoundInt
{
    static double Compoundint(double p, double r, double t)
    {
        double amt= p * Math.Pow((1 + r/100) , t);
        double ci= amt - p;
        return ci;

    }
   static void Main()
    {
        Console.Write("Enter original amount:");
        double p = double.Parse(Console.ReadLine());

        Console.Write("Enter rate of interest :");
        double r= double.Parse(Console.ReadLine());

        Console.Write("Enter time period in years:"); 
        double t = double.Parse(Console.ReadLine());
        double compound = Compoundint(p, r, t);
        Console.WriteLine("Compound Interest  is: {0}", compound);
        }
       
       
}