using System;

class Student
{
    public string name;

    public Student(string n)
    {
        name = n;
    }

    public void Display()
    {
        Console.WriteLine(name);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Sejal");
        s.Display();
    }
}