using System;

abstract class Animal
{
    public abstract void Sound();
}

interface IAnimal
{
    void Eat();
}

class Dog : Animal, IAnimal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }

    public void Eat()
    {
        Console.WriteLine("Dog eats");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Sound();
        d.Eat();
    }
}