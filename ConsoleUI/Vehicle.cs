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

        //abstract classes can have some things abstract:
        public abstract void DriveAbstract();
        //as well as some virtual:
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"Driving around town!");
        }

    }
}
