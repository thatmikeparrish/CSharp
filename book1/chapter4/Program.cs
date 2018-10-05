using System;
using System.Collections.Generic;


namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of planets
            List<string> planetList = new List<string>() {
                "Mercury", "Mars", "Venus", "Earth", "Neptune"
            };
            List<string> rockyPlanets = planetList.GetRange(0, 4);

            // Empty list of probes
            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();

            // Create probe
            Dictionary<string, string> viking = new Dictionary<string, string>();
            viking["Mars"] = "Viking";

            // Create probe
            Dictionary<string, string> opportunity = new Dictionary<string, string>() {
                { "Mars", "Opportunity" }
            };

            // Create probe
            Dictionary<string, string> mariner10 = new Dictionary<string, string>();
            mariner10.Add("Mercury", "Mariner 10");


            // Add probes to the List
            probes.Add(viking);
            probes.Add(opportunity);
            probes.Add(mariner10);

            /*
                The planet name itself is essentially a foreign key in the probes
                list back to the planet list.

                Iterate over all the planets.
             */
            foreach (string planet in planetList) // Mercury
            {
                // Build an initial list of string to hold the matching probe names
                List<string> visitedProbes = new List<string>();

                // Iterate over all the probes
                foreach (Dictionary<string, string> probe in probes) // Mercury, Mariner10
                {
                    /*
                        Does the current planet name in the dictionary match
                        the name of the planet in the planet list
                     */
                    if (probe.ContainsKey(planet)) {
                        visitedProbes.Add(probe[planet]);
                    }

                }

                // Output the name of the planet and comma separated list of matching probes
                if(visitedProbes.Count > 0) {
                    Console.WriteLine($"{planet}: {String.Join(", ", visitedProbes)}");
                }
            }
        }
    }
}