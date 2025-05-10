
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngelcraftsWebSite.Pages.Package
{
    public class Package
    {
        // Your class code here
        public void CalculateQuote()

        {
            // Print the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user to input the package weight
            Console.Write("Please enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // If the weight is greater than 50, show an error and end the program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program
            }

            // Ask the user to input the package width
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Ask the user to input the package height
            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Ask the user to input the package length
            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Check if the total dimensions (width + height + length) are greater than 50
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program
            }

            // Calculate the shipping quote:
            // Multiply width, height, and length together, then multiply by weight, then divide by 100
            double quote = (width * height * length * weight) / 100;

            // Display the quote as a formatted dollar amount with two decimal places
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

            // Print thank you message
            Console.WriteLine("Thank you!");
        }
    }
}

        
    




