using System;

namespace ConsoleApp
{
    // Define a class named MathOperations
    class MathOperations
    {
        // Define a void method that takes two integers as parameters
        public void PerformOperation(int number1, int number2)
        {
            // Multiply the first number by 2 (or any math operation you want)
            int result = number1 * 2;

            // Display the result of the operation (optional)
            Console.WriteLine("Result of number1 * 2: " + result);

            // Display the second number as required
            Console.WriteLine("Value of number2: " + number2);
        }
    }

    // Main program class
    class Program
    {
        // Main method: entry point of the console application
        static void Main(string[] args)
        {
            // Create an object (instantiate) of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method using positional parameters
            mathOps.PerformOperation(5, 10); // number1 = 5, number2 = 10

            // Call the method using named parameters
            mathOps.PerformOperation(number1: 7, number2: 20); // number1 = 7, number2 = 20

            // Keep console window open (optional for visibility)
            Console.ReadLine();
        }
    }
}
