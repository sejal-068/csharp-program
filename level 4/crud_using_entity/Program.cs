// Install EF Core packages before running

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        using (var db = new AppDbContext())
        {
            db.Students.Add(new Student { Name = "Sejal" });
            db.SaveChanges();

            var list = db.Students.ToList();
            foreach (var s in list)
                Console.WriteLine(s.Name);
        }
    }
}