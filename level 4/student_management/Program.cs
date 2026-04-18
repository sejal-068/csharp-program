using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        students.Add(new Student { Id = 1, Name = "Sejal" });
        students.Add(new Student { Id = 2, Name = "Aman" });

        foreach (var s in students)
        {
            Console.WriteLine(s.Id + " " + s.Name);
        }
    }
}