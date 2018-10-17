using System;
using System.Collections.Generic;

namespace chapter10
{
    class Cohort
    {
        public string Name { get; set; }

        public List<Student> StudentList = new List<Student> ();
        public List<Instructor> InstructorList = new List<Instructor> ();
    }
}
