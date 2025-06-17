using System;
using System.Collections.Generic;

namespace CSharpPortfolioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "C# Developer Portfolio";
            Portfolio portfolio = new Portfolio();
            portfolio.ShowMenu();
        }
    }

    class Portfolio
    {
        private List<Project> Projects;

        public Portfolio()
        {
            Projects = new List<Project>
            {
                new Project(
                    "Car Insurance Quote System",
                    "An ASP.NET MVC app that calculates insurance quotes based on user inputs. Includes admin dashboard to view issued quotes.",
                    new string[]
                    {
                        "ASP.NET MVC", "C#", "Entity Framework", "SQL Server", "Razor Views"
                    }
                ),
                new Project(
                    "NFL Stats Tracker",
                    "A fantasy football stats visualization and storage tool using Code First Entity Framework. Work in progress.",
                    new string[]
                    {
                        "Entity Framework 6", "Code First", "MVC", "Data Visualization"
                    }
                ),
                new Project(
                    "TwentyOne Console Game Debugging",
                    "Used Visual Studio debugging tools to step through a card game app. Learned logic flow with breakpoints and step-into.",
                    new string[]
                    {
                        "Debugging", "LINQ", "while loop logic", "Visual Studio tools"
                    }
                ),
                new Project(
                    "Code-First Console Student DB",
                    "Created a console app using EF Code First to build and populate a student database.",
                    new string[]
                    {
                        "Console App", "Entity Framework", "Code First", "SQL Database"
                    }
                )
            };
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== My C# Projects Portfolio ====\n");
                for (int i = 0; i < Projects.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Projects[i].Title}");
                }
                Console.WriteLine("0. Exit");

                Console.Write("\nSelect a project to view details: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int selection) && selection >= 0 && selection <= Projects.Count)
                {
                    if (selection == 0)
                        break;

                    ShowProjectDetails(selection - 1);
                }
                else
                {
                    Console.WriteLine("Invalid input. Press Enter to try again.");
                    Console.ReadLine();
                }
            }
        }

        private void ShowProjectDetails(int index)
        {
            Console.Clear();
            Project p = Projects[index];
            Console.WriteLine($"== {p.Title} ==\n");
            Console.WriteLine($"{p.Description}\n");
            Console.WriteLine("Technologies used:");
            foreach (var tech in p.Technologies)
            {
                Console.WriteLine($"- {tech}");
            }
            Console.WriteLine("\nPress Enter to return to the main menu...");
            Console.ReadLine();
        }
    }

    class Project
    {
        public string Title { get; }
        public string Description { get; }
        public string[] Technologies { get; }

        public Project(string title, string description, string[] technologies)
        {
            Title = title;
            Description = description;
            Technologies = technologies;
        }
    }
}
