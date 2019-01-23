using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndStatics
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar mustang = new Car();
            mustang.Drive();

            // CarLot carlot = new CarLot(); // Error!

            CarLot.Open();

            Console.WriteLine("Car lot is open? " + CarLot.IsOpen);

            CarLot.Close();
        }
    }
}
