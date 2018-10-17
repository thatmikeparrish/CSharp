using System.Collections.Generic;

namespace chapter14.Models
{
    // C# representation of the Department table
    public class Department
    {
        public int Id { get; set; }

        public string DeptName { get; set; }
        public List<Employee> Employees { get; set;} = new List<Employee>();
    }
}