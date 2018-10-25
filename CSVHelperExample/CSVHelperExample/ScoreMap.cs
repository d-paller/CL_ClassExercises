using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelperExample
{
    public class ScoreMap :ClassMap<Score>
    {
        public ScoreMap()
        {
            Map(x => x.City).Name("CITY");
            Map(x => x.InstitutionName).Name("INSTNM");
            Map(x => x.UnitId).Name("UNITID");
            Map(x => x.State).Name("STABBR");
            Map(x => x.InstitutionUrl).Name("INSTURL");
            Map(x => x.SATReadingAverage).Name("SATVRMID")
                .ConvertUsing(row => {
                    var data = row.GetField("SATVRMID");
                    if (data == "NULL")
                    {
                        return null;
                    }
                    else
                    {
                        return int.Parse(data);
                    }
                    });
            Map(x => x.SATMathAverage).Name("SATMTMID").ConvertUsing(row => {
                var data = row.GetField("SATMTMID");
                if (data == "NULL")
                {
                    return null;
                }
                else
                {
                    return int.Parse(data);
                }
            });
            Map(x => x.SATWritingAverage).Name("SATWRMID").ConvertUsing(row => {
                var data = row.GetField("SATWRMID");
                if (data == "NULL")
                {
                    return null;
                }
                else
                {
                    return int.Parse(data);
                }
            });
        }
    }
}
