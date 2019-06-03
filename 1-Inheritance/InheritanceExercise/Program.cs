using System;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mustang = new Car();
            mustang.MPG = 8;
            mustang.Model = "Mustang";
            mustang.Year = 2014;

            Console.WriteLine(mustang.Year + " " + mustang.Model + " gets only " + mustang.MPG + " miles per gallon");
            Console.WriteLine(mustang.Drive2());
            Console.WriteLine(mustang.Drift2());

            mustang.Drive();
            mustang.Drift();
        }
    }
}
