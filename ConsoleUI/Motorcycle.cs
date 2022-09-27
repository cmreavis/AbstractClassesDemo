using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
         public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine($"Riding my {Year} {Make} {Model} around town!");
        }

        public override void DriveVirtual(Vehicle vehicle)
        {
            base.DriveVirtual(vehicle);
        }

        public bool hasSidecar;
    }
}
