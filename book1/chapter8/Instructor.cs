using System;

namespace chapter8
{
    class Instructor
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slackHandle { get; set; }
        public Cohort InstructorCohort { get; set; }

        public void Assignment(Exercise exercise, Student student) {
            student.ExerciseList.Add(exercise);
        }
    }
}
