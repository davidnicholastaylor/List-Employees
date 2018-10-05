using System;
using System.Collections.Generic;

namespace class_types {

    public class Employee {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

    }

    public class Company {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees

        public List<Employee> employeesList { get; set; }

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
            employeesList = new List<Employee> ();
        }

    }

    class Program {
        static void Main (string[] args) {
            // Create an instance of a company. Name it whatever you like.

            Company fremulon = new Company("Fremulon", DateTime.Now);

            // Create three employees

            Employee george = new Employee() 
            {
                FirstName = "George",
                LastName = "Cantstandya",
                Title = "Jester",
                StartDate = new DateTime(2011, 8, 23)
            };

            Employee beth = new Employee()
            {
                FirstName = "Beth",
                LastName = "Any",
                Title = "Queen",
                StartDate = DateTime.Now
            };
            
            Employee blake = new Employee()
            {
                FirstName = "Blake",
                LastName = "Blakerson",
                Title = "Fire",
                StartDate = DateTime.Now
            };

            // Assign the employees to the company

            fremulon.employeesList.Add(george);
            fremulon.employeesList.Add(beth);
            fremulon.employeesList.Add(blake);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            foreach (Employee employee in fremulon.employeesList)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {fremulon.Name} as since {employee.StartDate}");
            }

        }
    }
}