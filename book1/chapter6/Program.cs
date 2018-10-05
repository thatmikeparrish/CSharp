using System;
using System.Collections.Generic;

namespace chapter6 {
    class Program {
        static void Main (string[] args) {
            List<string> Showroom = new List<string> () {
                "Mustang",
                "Mustang",
                "Shelby GT",
                "1500",
                "Stingray",
            };
                Showroom.Remove("1500");

            List<string> UsedLot = new List<string> () {
                "Taurus",
                "Forte",
            };

            List<string> JunkYard = new List<string> () {
                "Mach II",
                "F-250",
                "2500",
                "Stingray",
            };
                JunkYard.Remove("2500");

            HashSet<string> clone = new HashSet<string>(Showroom);
            clone.IntersectWith(JunkYard);

            HashSet<string> allModels = new HashSet<string> ();

            foreach (string model in Showroom) {
                allModels.Add(model);
                allModels.UnionWith(UsedLot);
                allModels.IntersectWith(clone); //This only returns the difference
                allModels.UnionWith(JunkYard); //This adds the two lists together
                allModels.UnionWith(Showroom);
            }

            // Display all unique model names
            foreach (string vehicle in allModels) {
                Console.WriteLine ($"{vehicle}");
            }
        }
    }
}