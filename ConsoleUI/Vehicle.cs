using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Year { get; set; } = "2000";
        public string Make { get; set; } = "Fjord";
        public string Model { get; set; } = "Model Y";

        public abstract void DriveAbstract(Vehicle vehicle);

        public virtual void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine($"Driving around town in my {vehicle.Year} {vehicle.Make} {vehicle.Model}!");
        }

    }
}
