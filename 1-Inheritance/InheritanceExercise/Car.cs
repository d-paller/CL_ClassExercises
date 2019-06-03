using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercise
{
    public class Car : Vehicle
    {
        public int MPG { get; set; }

        public void Drift()
        {

            Console.WriteLine("Car is drifting!");
        }

        public string Drift2()
        {
            return "Car is Drifting!";
        }
    }
}
