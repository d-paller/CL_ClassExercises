using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileParser parser = new FileParser();

            var data = parser.Read("../../../data.txt");

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }

            Console.ReadKey();
        }
    }
}
