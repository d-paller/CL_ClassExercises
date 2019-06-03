using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user what they would like to call their file.  
            Console.Write("Enter a file name: ");
            // Store the input in variable called "fileName"
            string fileName = Console.ReadLine();

            // Append .txt to the end of fileName
            fileName = fileName + ".txt";

            // Create a File utility object here
            // Give it the fileName object.
            IFileUtility fileUtility = new FileUtility(fileName);

            // Ask the user for data to put into the file
            Console.WriteLine("Enter some data for the file");

            // Store the user input in a variable called data
            string data = Console.ReadLine();

            // Write the data to the file using your fileUtility
            fileUtility.WriteToFile(data);

            // Give a message to the user telling them data was written to the file
            Console.WriteLine("Your data has been written to the file");

            // Display the data from the file
            Console.WriteLine("File Contents: " + fileUtility.ReadFromFile());

            // Add Console.ReadKey to make sure that the console window doesn't close
            Console.ReadKey();
        }
    }
}
