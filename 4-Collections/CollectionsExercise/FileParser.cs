using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExercise
{
    public class FileParser : IFileParser
    {
        public string[] Read(string path)
        {
            // Initialize local variables
            int arraySize = 0;
            string[] array;
            
            // Create a new stream reader
            var reader = new StreamReader(path);

            // Get the array size (how many rows of data are in the text file) from the file
            arraySize = int.Parse(reader.ReadLine());

            // Create the array using the array size you got from the file
            array = new string[arraySize];

            // Loop through the array giving it values
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = reader.ReadLine();
            }
            
            // Clean up
            // Close the stream
            reader.Close();
            // Use the built in Dispose method to properly dispose of the object
            reader.Dispose();

            // Return the array with all of the data from the text file
            return array;
        }
    }
}
