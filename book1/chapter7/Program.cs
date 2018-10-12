using System;

namespace chapter7 {
    class Program {
        static void Main (string[] args) {
            // Create an instance of a company. Name it whatever you like.
// Create three employees
            Employee Mike = new Employee () {
                firstName = "Mike",
                lastName = "Parrish",
                title = "Partner",
                startDate = DateTime.Now
            };

            Employee Kayla = new Employee () {
                firstName = "Kayla",
                lastName = "Carter",
                title = "Boss",
                startDate = DateTime.Now
            };

            Employee Dwayne = new Employee () {
                firstName = "Dwayne",
                lastName = "Fleenor",
                title = "Coder",
                startDate = DateTime.Now
            };

            // Assign the employees to the company
            Company DaPlace = new Company ("5th Gear Coding", DateTime.Now) {};

            DaPlace.AddEmployee(Mike);
            DaPlace.AddEmployee(Kayla);
            DaPlace.AddEmployee(Dwayne);


            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            DaPlace.EmployeeList.ForEach(employee => Console.WriteLine($"{employee.firstName} {employee.lastName} has worked at {DaPlace.Name} since {employee.startDate}"));
        }
    }
}