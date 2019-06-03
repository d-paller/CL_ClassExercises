using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekThreeExercise
{
    public class Phone
    {
        public string Model { get; set; }

        public string Brand { get; set; }

        public int InternalStorage { get; set; }

        public double ScreenSize { get; set; }

        public void OutputToFile()
        {

            using (StreamWriter writer = new StreamWriter("Phone.txt"))
            {
                writer.WriteLine(Brand + " " + Model);
                writer.WriteLine("=========================");
                writer.WriteLine("Screen Size: " + ScreenSize);
                writer.WriteLine("Internal Storage Size: " + ScreenSize);
            }
        }

    }
}
