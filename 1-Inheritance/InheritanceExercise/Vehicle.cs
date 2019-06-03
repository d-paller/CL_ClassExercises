using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercise
{
    public class Vehicle
    {
        public int Year { get; set; }

        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine("Vehicle is driving!");
        }

        public string Drive2()
        {
            return "Vehicle is Driving!";
        }
    }
}
