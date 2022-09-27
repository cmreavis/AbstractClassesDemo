using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine($"Driving around my {Year} {Make} {Model}.");
        }

        public int numDoors;


    }
}
