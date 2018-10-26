using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelperExample
{
    public class ScoreMap : ClassMap<Score>
    {
        // Map the csv row to the Score object
        public ScoreMap()
        {
            Map(x => x.City).Name("CITY");
            Map(x => x.InstitutionName).Name("INSTNM");
            Map(x => x.UnitId).Name("UNITID");
            Map(x => x.State).Name("STABBR");
            Map(x => x.InstitutionUrl).Name("INSTURL");

            Map(x => x.SATReadingAverage).Name("SATVRMID")
                // Special conversion rules
                .ConvertUsing(row =>
                {
                    // Get the data in the row
                    var data = row.GetField("SATVRMID");

                    // If the data value is NULL, set the value to actual null
                    if (data == "NULL")
                    {
                        return null;
                    }
                    // Otherwise, parse the string into an int
                    else
                    {
                        return int.Parse(data);
                    }
                });
            Map(x => x.SATMathAverage).Name("SATMTMID")
                // Special conversion rules
                .ConvertUsing(row =>
                {
                    // Get the data in the row
                    var data = row.GetField("SATMTMID");

                    // If the data value is NULL, set the value to actual null
                    if (data == "NULL")
                    {
                        return null;
                    }
                    // Otherwise, parse the string into an int
                    else
                    {
                        return int.Parse(data);
                    }
                });
            Map(x => x.SATWritingAverage).Name("SATWRMID")
                // Special conversion rules
                .ConvertUsing(row =>
                {
                    // Get the data in the row
                    var data = row.GetField("SATWRMID");

                    // If the data value is NULL, set the value to actual null
                    if (data == "NULL")
                    {
                        return null;
                    }
                    // Otherwise, parse the string into an int
                    else
                    {
                        return int.Parse(data);
                    }
                });
        }
    }
}
