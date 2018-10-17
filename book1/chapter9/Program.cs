using System;
using System.Collections.Generic;
using System.Linq;

namespace chapter9 {
    class Program {
        static void Main (string[] args) {
            // Restriction/Filtering Operations
            Console.WriteLine ($@"
            Restriction/Filtering Operations
Find the words in the collection that start with the letter 'L'
");
            List<string> fruits = new List<string> () { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = fruits.Where (fruit => fruit.StartsWith ("L"));

            foreach (string fruit in LFruits) {
                Console.WriteLine (fruit);
            }

            Console.WriteLine ($@"
Which of the following numbers are multiples of 4 or 6
");
            List<int> numbers = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where (x => x % 4 == 0 && x % 6 == 0);

            foreach (int x in fourSixMultiples) {
                Console.WriteLine (x);
            }

            Console.WriteLine ($@" 
            Ordering Operations
Order these student names alphabetically, in descending order (Z to A)
");
            List<string> names = new List<string> () {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            List<string> descend = (from x in names orderby x descending select x).ToList ();

            foreach (string x in descend) {
                Console.WriteLine (x);
            }

            Console.WriteLine ($@" 
Build a collection of these numbers sorted in ascending order
");
            List<int> numbers2 = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            List<int> ascend = (from n in numbers2 orderby n select n).ToList ();

            foreach (int n in ascend) {
                Console.WriteLine (n);
            }

            Console.WriteLine ($@" 
            Aggregate Operations
Output how many numbers are in this list
");
            List<int> numbers3 = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            Console.WriteLine ($"Total {numbers3.Count()}");

            Console.WriteLine ($@" 
How much money have we made?
");
            List<double> purchases = new List<double> () {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };

            Console.WriteLine ($"Total {purchases.Sum().ToString("C")}");

            Console.WriteLine ($@" 
What is our most expensive product?
");
            List<double> prices = new List<double> () {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };

            Console.WriteLine ($"Most expensive: {purchases.Max().ToString("C")}");

            Console.WriteLine ($@" 
            Partitioning Operations
Store each number in the following List until a perfect square is detected.
");
            List<int> wheresSquaredo = new List<int> () {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };

            wheresSquaredo.ForEach (g => {
                if (Math.Sqrt (g) % 1 == 0) {
                    Console.WriteLine ($"{g.ToString()} = {Math.Sqrt(g)}");
                }
            });

            Console.WriteLine ($@" 
            Using Custom Types
Build a collection of customers who are millionaires.
");
            public class Customer {
                public string Name { get; set; }
                public double Balance { get; set; }
                public string Bank { get; set; }
            };

            List<Customer> customers = new List<Customer> () {
                new Customer () { Name = "Bob Lesman", Balance = 80345.66, Bank = "FTB" },
                new Customer () { Name = "Joe Landy", Balance = 9284756.21, Bank = "WF" },
                new Customer () { Name = "Meg Ford", Balance = 487233.01, Bank = "BOA" },
                new Customer () { Name = "Peg Vale", Balance = 7001449.92, Bank = "BOA" },
                new Customer () { Name = "Mike Johnson", Balance = 790872.12, Bank = "WF" },
                new Customer () { Name = "Les Paul", Balance = 8374892.54, Bank = "WF" },
                new Customer () { Name = "Sid Crosby", Balance = 957436.39, Bank = "FTB" },
                new Customer () { Name = "Sarah Ng", Balance = 56562389.85, Bank = "FTB" },
                new Customer () { Name = "Tina Fey", Balance = 1000000.00, Bank = "CITI" },
                new Customer () { Name = "Sid Brown", Balance = 49582.68, Bank = "CITI" }
            };
        }
    }
}