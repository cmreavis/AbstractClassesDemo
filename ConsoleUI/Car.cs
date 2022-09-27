using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine($"Driving around in my car!");
        }

        public int numDoors { get; set; }

    }
}
