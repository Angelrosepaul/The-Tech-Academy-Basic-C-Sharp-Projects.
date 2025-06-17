
    using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]  // Marks this as the primary key
    public int StudentId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}
using System.Data.Entity;

public class StudentContext : DbContext
{
    public StudentContext() : base("StudentDbConnection")
    {
    }

    public DbSet<Student> Students { get; set; }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new StudentContext())
        {
            var student = new Student
            {
                FirstName = "John",
                LastName = "Doe"
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully.");
        }

        Console.ReadLine();
    }
}
< connectionStrings >
  < add name = "StudentDbConnection"
       connectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;"
       providerName = "System.Data.SqlClient" />
</ connectionStrings >
