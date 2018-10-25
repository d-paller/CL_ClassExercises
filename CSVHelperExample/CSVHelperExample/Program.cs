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
            List<Score> scores;
            using (var streamReader = new StreamReader("../../SATMidScores.csv"))
            using (var reader = new CsvReader(streamReader))
            {
                reader.Configuration.RegisterClassMap<ScoreMap>();
                scores = reader.GetRecords<Score>().ToList();
            }

            StringBuilder menu = new StringBuilder();
            menu.Append(DIV)
                .Append("\nMenu\n")
                .Append(DIV)
                .Append("\nEnter 1 to display all records")
                
                .Append("\nEnter Q to quit");

            Console.WriteLine(menu.ToString());
            var input = Console.ReadLine();
            while (input.ToUpper() != "Q")
            {
                switch (input)
                {
                    case "1":
                        PrintList(scores);
                        break;
                    default:
                        Console.WriteLine("Command not recognized");
                        break;
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintList(List<Score> scores)
        {
            foreach (var score in scores)
            {
                Console.WriteLine(DIV);
                Console.WriteLine(score.ToString());
                Console.WriteLine(DIV);
            }
        }
    }
}
