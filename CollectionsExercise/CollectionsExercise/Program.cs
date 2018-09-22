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
            MyList list = new MyList(5);
            string three = "three";
            int four = 4;

            list.Add("one");
            list.Add("two");
            list.Add(three);
            list.Add(four.ToString());
            list.Add("lastItem");

            Console.WriteLine("Item at index 0: " + list.Get(0));
            Console.WriteLine("Item at index 1: " + list.Get(1));
            Console.WriteLine("Item at index 4 (which will be the last item): " + list.Get(four));

            Console.WriteLine("The whole list");
            Console.WriteLine(list.ToString());

            Console.WriteLine("Index of two: " + list.Contains("two"));

            Console.ReadKey();
        }
    }
}
