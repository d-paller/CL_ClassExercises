using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelperExample
{
    public class Score
    {
        public int UnitId { get; set; }

        public string InstitutionName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string InstitutionUrl { get; set; }

        public int? SATReadingAverage { get; set; }

        public int? SATMathAverage { get; set; }

        public int? SATWritingAverage { get; set; }

        /// <summary>
        /// Print each property name with it's value on a new line
        /// </summary>
        /// <returns>A string.... duh</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nUnitId: ").Append(UnitId)
                .Append("Institution Name: ").Append(InstitutionName)
                .Append("\nState: ").Append(State)
                .Append("\nInstitution URL: ").Append(InstitutionName)
                .Append("\nSAT Average Reading Score: ").Append(SATReadingAverage)
                .Append("\nSAT Average Math Score: ").Append(SATMathAverage)
                .Append("\nSAT Average Writing Score: ").Append(SATWritingAverage);

            return sb.ToString();
        }
    }
}
