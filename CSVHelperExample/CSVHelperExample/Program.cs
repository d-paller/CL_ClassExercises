using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelperExample
{
    // Install the CSVHelper nuget oackage to your project (righclick project [not solution] > manage nuget packages > browse > search "csvhelper"
    // Go look at the csv in the root folder of the project
    class Program
    {
        public const string DIV = "-----------------------------";

        static void Main(string[] args)
        {
            // Declare out here because it is needed outsie of the usings
            List<Score> scores;

            // csv reader needs a stream, so declare that one first then pass that into the csv reader
            using (var streamReader = new StreamReader("../../SATMidScores.csv"))
            using (var reader = new CsvReader(streamReader))
            {
                // Register the custom score map
                // That takes care of how the csv file will be mapped to Score
                reader.Configuration.RegisterClassMap<ScoreMap>();

                // Read all of the records and put them into a list
                scores = reader.GetRecords<Score>()
                    .ToList();
            }

            // Create the menu string
            StringBuilder menu = new StringBuilder();
            menu.Append(DIV)
                .Append("\nMenu\n")
                .Append(DIV)
                .Append("\nEnter 1 to display all records")
                
                .Append("\nEnter Q to quit");

            // Write the menu
            Console.WriteLine(menu.ToString());
            
            // Get the first input
            var input = Console.ReadLine();

            // Keep going unless someone enters Q
            while (input.ToUpper() != "Q")
            {
                switch (input)
                {
                    // Print the list
                    case "1":
                        PrintList(scores);
                        break;
                    // If the command isn't one of the designated values, print a nice message
                    default:
                        Console.WriteLine("Command not recognized");
                        break;
                }

                // Get the input
                input = Console.ReadLine();
            }
        }

        // Print the given list
        private static void PrintList(List<Score> scores)
        {
            // For all the scores in the list
            foreach (var score in scores)
            {
                // Use Score's overriden ToString method
                Console.WriteLine(DIV);
                Console.WriteLine(score.ToString());
                Console.WriteLine(DIV);
            }
        }
    }
}
