using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekThreeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            Console.WriteLine("Enter phone brand: ");
            phone.Brand = Console.ReadLine();

            Console.WriteLine("Enter phone model: ");
            phone.Model = Console.ReadLine();

            Console.WriteLine("Enter phone's internal storage: ");
            phone.InternalStorage = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter phone screen size: ");
            phone.ScreenSize = double.Parse(Console.ReadLine());

            phone.OutputToFile();

            Console.WriteLine("File has been created");

            Console.ReadKey();
        }
    }
}
