using System;
using System.Collections.Generic;

namespace NSSOrientation {
    public class Program {
        public static void Main () {
            List<string> students = new List<string> () {
                "Megan",
                "Damon",
                "Chase",
                "Tekisha",
                "Castle",
                "Mark",
                "Keith",
                "Adam",
                "Patrick",
                "Hannah",
                "Mike"
            };

            // Can't do this easily with a base array
            students.Add ("Melanie");
            students.Insert (3, "Simon");

            if (students.Contains ("Chase")) {
                Console.WriteLine ("Must be cohort 13");
            }

            // This looks a lot like JavaScript!
            students.ForEach (stu => Console.WriteLine (stu));

            Dictionary<string, int> toysSold = new Dictionary<string, int> () { 
                { "Hot Wheels", 344 }, 
                { "Legos", 763 }, 
                { "Gaming Consoles", 551 }, 
                { "Board Games", 298 }
            };
            toysSold.Add("Razor Scooter", 60);

            foreach (KeyValuePair<string, int> item in toysSold) 
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}