using System;
using System.Collections.Generic;

namespace class_types {

    public class Employee {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string StartDate { get; set; }

    }

    public class Company {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees

        List<string> employeesList = new List<string>();

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */

        public Company(string companyName, DateTime companyStart) 
        {
            Name = companyName;
            CreatedOn = companyStart;
        }

    }

    class Program {
        static void Main (string[] args) {
            // Create an instance of a company. Name it whatever you like.

            Company Fremulon = new Company()
            {
                Name = "Fremulon",
                CreatedOn = "January 1, 2007"
            };

            // Create three employees

            Employee George = new Employee() 
            {
                FirstName = "George",
                LastName = "Cantstandya",
                Title = "Jester",
                StartDate = "Yesterday"
            };

            Employee Beth = new Employee()
            {
                FirstName = "Beth",
                LastName = "Any",
                Title = "Queen",
                StartDate = "The dawn of time"
            };
            
            Employee Blake = new Employee()
            {
                FirstName = "Blake",
                LastName = "Blakerson",
                Title = "Fire",
                StartDate = "Four score and 7 years ago"
            };

            // Assign the employees to the company

            employeesList.Add($"{George}");
            employeesList.Add($"{Beth}");
            employeesList.Add($"{Blake}");

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            foreach (string employee in employeesList)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Company.companyName} as since {employee.StartDate}");
            }

        }
    }
}