using System;
using System.Collections.Generic;

namespace chapter7 {
    public class Company {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> EmployeeList = new List<Employee>();

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string CompanyName, DateTime DateCreated) {
            Name = CompanyName;
            CreatedOn = DateCreated;
        }

        public void AddEmployee(Employee word) {
            EmployeeList.Add(word);
        }
    }
}