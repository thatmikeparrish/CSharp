using System;
using System.Collections.Generic;
using System.Linq;

namespace StEx
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
                Language = "JavaScript"
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

            Exercise Another3 = new Exercise {
                Name = "Another3",
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
                slackHandle = "@lilC",
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

            Student Bill = new Student {
                firstName = "Bill",
                lastName = "Dollar",
                slackHandle = "@money",
                StudentCohort = Cohort27
            };

            // Create 3 Instructors
            Instructor Steve = new Instructor {
                firstName = "Steve",
                lastName = "Norris",
                slackHandle = "@coach",
                InstructorCohort = Cohort27
            };

            Instructor Andy = new Instructor {
                firstName = "Andy",
                lastName = "Steve^2",
                slackHandle = "@coach^2",
                InstructorCohort = Cohort28
            };

            Instructor Meg = new Instructor {
                firstName = "Meg",
                lastName = "Steve^3",
                slackHandle = "@jrcoach",
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
            Andy.Assignment(Another3, Mike);

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
            students.Add(Bill);

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
                foreach (Exercise exercise in exercises) {
                    if(student.ExerciseList.Contains(exercise)) {
                        Console.WriteLine($"{exercise.Name} has been assigned to {student.firstName}.");
                    }
                }
            }

            // List exercises for the JavaScript language by using the Where() LINQ method.
            IEnumerable<Exercise> JavaScriptLessions = exercises.Where(L => L.Language == "JavaScript");
            foreach( var L in JavaScriptLessions) {
                Console.WriteLine($"Exercises in JavaScript: {L.Name}");
            };

            // List students in a particular cohort by using the Where() LINQ method.
            IEnumerable<Student> SC27 = students.Where(s => s.StudentCohort.Name == "Cohort 27");
            foreach( var s in SC27) {
                Console.WriteLine($"{s.firstName} {s.lastName} is in {s.StudentCohort.Name}");
            };

            IEnumerable<Student> SC28 = students.Where(s => s.StudentCohort.Name == "Cohort 28");
            foreach( var s in SC28) {
                Console.WriteLine($"{s.firstName} {s.lastName} is in {s.StudentCohort.Name}");
            };

            // List instructors in a particular cohort by using the Where() LINQ method.
            List<Instructor> instructors = new List<Instructor>();
            instructors.Add(Steve);
            instructors.Add(Andy);
            instructors.Add(Meg);

            IEnumerable<Instructor> IC27 = instructors.Where(s => s.InstructorCohort.Name == "Cohort 27");
            foreach( var s in IC27) {
                Console.WriteLine($"{s.firstName} {s.lastName} is in {s.InstructorCohort.Name}");
            };

            IEnumerable<Instructor> IC28 = instructors.Where(s => s.InstructorCohort.Name == "Cohort 28");
            foreach( var s in IC28) {
                Console.WriteLine($"{s.firstName} {s.lastName} is in {s.InstructorCohort.Name}");
            };

            // Sort the students by their last name.
            IEnumerable<Student> StudentByLastName = students.OrderBy(x => x.lastName);
            foreach( var x in StudentByLastName) {
                Console.WriteLine($"{x.lastName}, {x.firstName}");
            };

            // Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            IEnumerable<Student> NoExercises = students.Where(x => x.ExerciseList.Count == 0);
            foreach( var x in NoExercises) {
                Console.WriteLine($"{x.firstName} {x.lastName} isn't working on anything.");
            };

            // Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            IEnumerable<Student> MostExercises = students.Where(x => x.ExerciseList.Count == students.Max(p => p.ExerciseList.Count));
            foreach( var x in MostExercises) {
                Console.WriteLine($"{x.firstName} {x.lastName} is working on the most with {x.ExerciseList.Count}");
            };
            // need another way to do this. Andy said it was bad..  Mainly because its nested loops and uses to much memory

            // How many students in each cohort?
            var CohortSize = students.GroupBy(x => x.StudentCohort.Name);
            foreach (var SG in CohortSize) {
                Console.WriteLine($"{SG.Key} has {SG.Count()} student(s).");
            };

            }

        }
    }
