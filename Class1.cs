using System;

// Define an interface called IQuittable with a void Quit method
public interface IQuittable
{
    void Quit();  // Method signature for quitting action
}

// Define a base Employee class
public class Employee : IQuittable  // Employee implements IQuittable interface
{
    // Properties for Employee class
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }

    // Implement the Quit method from IQuittable interface
    public void Quit()
    {
        // Implementation of quitting - just print a message here
        Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the company.");
    }
}

class Program
{
    static void Main()
    {
        // Create an Employee object and set properties
        Employee employee = new Employee() { FirstName = "Jane", LastName = "Doe", Id = 123 };

        // Use polymorphism: Declare an object of interface type IQuittable and assign the Employee instance to it
        IQuittable quittableEmployee = employee;

        // Call the Quit method on the IQuittable object (polymorphic behavior)
        quittableEmployee.Quit();

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}


