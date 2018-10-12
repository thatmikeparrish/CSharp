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
Store each number in the following List until a perfect square
    is detected.
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
        }
    }
}