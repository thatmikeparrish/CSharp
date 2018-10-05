using System;
using System.Collections.Generic;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {
            Dictionary<string, string> stocks = new Dictionary<string, string> () {
                { "GM", "General Motors" },
                { "GE", "General Electric" },
                { "CAT", "Caterpillar" },
                { "AAPL", "Apple" },
                { "MSFT", "Microsoft" },
            };

            // List of dictionaries for purchases
            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();

            // Create some purchases
            purchases.Add(new Dictionary<string, double>() { { "AAPL", 2100.32 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 1570.60 } });
            purchases.Add(new Dictionary<string, double>() { { "MSFT", 10000.00 } });
            purchases.Add(new Dictionary<string, double>() { { "GE", 1200.00 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 893.28 } });
            purchases.Add(new Dictionary<string, double>() { { "AAPL", 5500.91 } });

            /*
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the total valuation of each stock


                From the three purchases above, one of the entries
                in this new dictionary will be...
                    {"General Electric", 1217.53}

                Replace the questions marks below with the correct types.
            */
            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            /*
               Iterate over the purchases and record the valuation
               for each stock.
            */
            foreach (Dictionary<string, double> purchase in purchases)
            {
                foreach (KeyValuePair<string, double> transaction in purchase)
                {
                    string fullCompanyName = stocks[transaction.Key]; //returns "Apple"

                    if (stockReport.ContainsKey(fullCompanyName))
                    {
                        // stockReport[fullCompanyName] += transaction.Value;
                        stockReport[fullCompanyName] = stockReport[fullCompanyName] + transaction.Value;
                    } else {
                        // stockReport.Add(fullCompanyName, transaction.Value);
                        stockReport[fullCompanyName] = transaction.Value;
                    }
                }
            }

            // Dictionary<string, double> stockReport = new Dictionary<string, double>();

            // Display all holdings and their valuations
            foreach (KeyValuePair<string, double> valuation in stockReport)
            {
                Console.WriteLine($"{valuation.Key} has a valuation of {valuation.Value.ToString("C")}");
            }
        }
    }
}