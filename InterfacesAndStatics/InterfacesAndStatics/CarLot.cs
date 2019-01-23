using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndStatics
{
    public static class CarLot
    {
        public static bool IsOpen { get; set; }

        public static void Open()
        {
            IsOpen = true;
            Console.WriteLine("The car lot is open");
        }

        public static void Close()
        {
            IsOpen = false;
            Console.WriteLine("The car lot is closed");
        }
    }
}
