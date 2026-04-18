using System;

class maxiofThree
{
    static void maximumof03(int a, int b, int c){
        if(a>=b && a>=c){
            Console.WriteLine($"{a} is greater than b & c. ");
        }
        else if(b>=a && b>=c){
              Console.WriteLine($"{b} is greater than a &c. ");
        }
        else{
             Console.WriteLine($" c : cd {c} is greater than a &b. ");
        }
        
    }
    

    static void Main(){
          Console.Write("enter the value of a :");
          int a= int.Parse(Console.ReadLine());

          Console.Write("enter the value of b :");
          int b= int.Parse(Console.ReadLine());

          Console.Write("enter the value of c :");
          int c= int.Parse(Console.ReadLine());
        
        maximumof03(a,b,c);
    }
}