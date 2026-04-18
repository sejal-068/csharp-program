using System;

class swapof2{

static void Main(){
     Console.Write("enter the value of a :");
     int a = int.Parse(Console.ReadLine());

     Console.Write("enter the value of b :");
     int b = int.Parse(Console.ReadLine());

     int temp;
     temp =a;
     a=b;
     b= temp;

     Console.WriteLine($"after swapping a is {a}");
     Console.WriteLine($"after swapping b is {b}");




}



}