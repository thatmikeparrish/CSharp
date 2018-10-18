using System;
using System.Collections.Generic;

namespace StEx
{
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slackHandle { get; set; }
        public Cohort StudentCohort { get; set; }

       public List<Exercise> ExerciseList = new List<Exercise> ();

        internal static IEnumerable<Student> Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
