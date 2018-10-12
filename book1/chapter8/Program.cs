using System;
using System.Collections.Generic;

namespace chapter8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4 Exercises
            Exercise FizzBuzzJS = new Exercise {
                Name = "FizzBuzzJS",
                Language = "JavaScript"
            };

            Exercise FizzBuzzCSharp = new Exercise {
                Name = "FizzBuzzCSharp",
                Language = "C#"
            };

            Exercise ChickenMonkeyJS = new Exercise {
                Name = "ChickenMonkeyJS",
                Language = "C#"
            };

            Exercise ChickenMonkeyCSharp = new Exercise {
                Name = "ChickenMonkeyCSharp",
                Language = "C#"
            };

            Exercise Another1 = new Exercise {
                Name = "Another1",
                Language = "Binary"
            };

            Exercise Another2 = new Exercise {
                Name = "Another2",
                Language = "Hieroglyphics"
            };

            // Create 3 Cohorts
            Cohort Cohort27 = new Cohort {
                Name = "Cohort 27"
            };
            Cohort Cohort28 = new Cohort {
                Name = "Cohort 28"
            };
            Cohort Cohort29 = new Cohort {
                Name = "Cohort 29"
            };

            // Create 4 Students
            Student Mike = new Student {
                firstName = "Mike",
                lastName = "Parrish",
                slackHandle = "@thatmikeparrish",
                StudentCohort = Cohort27
            };

            Student Kayla = new Student {
                firstName = "Kayla",
                lastName = "Carter",
                slackHandle = "@lil'C",
                StudentCohort = Cohort28
            };

            Student Chad = new Student {
                firstName = "Chad",
                lastName = "Taylor",
                slackHandle = "@chadalac",
                StudentCohort = Cohort28
            };

            Student Josh = new Student {
                firstName = "Josh",
                lastName = "Perez",
                slackHandle = "@ohdang",
                StudentCohort = Cohort29
            };

            // Create 3 Instructors
            Instructor Steve = new Instructor {
                firstName = "Steve",
                lastName = "Norris",
                slackHandle = "coach",
                InstructorCohort = Cohort27
            };

            Instructor Andy = new Instructor {
                firstName = "Andy",
                lastName = "Steve^2",
                slackHandle = "coach^2",
                InstructorCohort = Cohort28
            };

            Instructor Meg = new Instructor {
                firstName = "Meg",
                lastName = "Armstrong",
                slackHandle = "jrcoach",
                InstructorCohort = Cohort29
            };

            // Have each instructor assign 2 exercises to each of the students
            Steve.Assignment(FizzBuzzJS, Mike);
            Steve.Assignment(FizzBuzzCSharp, Mike);
            Steve.Assignment(FizzBuzzJS, Josh);
            Steve.Assignment(FizzBuzzCSharp, Josh);
            Steve.Assignment(FizzBuzzJS, Kayla);
            Steve.Assignment(FizzBuzzCSharp, Kayla);
            Steve.Assignment(FizzBuzzJS, Chad);
            Steve.Assignment(FizzBuzzCSharp, Chad);

            Andy.Assignment(Another1, Mike);
            Andy.Assignment(Another2, Mike);
            Andy.Assignment(Another1, Josh);
            Andy.Assignment(Another2, Josh);
            Andy.Assignment(Another1, Kayla);
            Andy.Assignment(Another2, Kayla);
            Andy.Assignment(Another1, Chad);
            Andy.Assignment(Another2, Chad);

            Meg.Assignment(ChickenMonkeyJS, Mike);
            Meg.Assignment(ChickenMonkeyCSharp, Mike);
            Meg.Assignment(ChickenMonkeyJS, Josh);
            Meg.Assignment(ChickenMonkeyCSharp, Josh);
            Meg.Assignment(ChickenMonkeyJS, Kayla);
            Meg.Assignment(ChickenMonkeyCSharp, Kayla);
            Meg.Assignment(ChickenMonkeyJS, Chad);
            Meg.Assignment(ChickenMonkeyCSharp, Chad);

            // Challenge: Create a list of students, and add all of the students to the list.
            List<Student> students = new List<Student>();
            students.Add(Mike);
            students.Add(Kayla);
            students.Add(Josh);
            students.Add(Chad);

            //Challenge: Create a list of exercises, and add all of the exercises to the list.
            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(FizzBuzzJS);
            exercises.Add(FizzBuzzCSharp);
            exercises.Add(ChickenMonkeyJS);
            exercises.Add(ChickenMonkeyCSharp);
            exercises.Add(Another1);
            exercises.Add(Another2);

            // Challenge: Generate a report that displays which students are working on which exercise.
            foreach(Student student in students) {
                foreach (Exercise exercise in exercises)
                {
                    if(student.ExerciseList.Contains(exercise)) {
                        Console.WriteLine($"{exercise.Name} has been assigned to {student.firstName}.");
                    }
                }
            }
        }
    }
}
