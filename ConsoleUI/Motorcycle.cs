using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        //ctrl + . opens what you need to implement from parent class
         public override void DriveAbstract()
        {
            Console.WriteLine($"Riding my motorcycle around town!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This motorcycle is being ridden around town!");
        }

        public bool hasSidecar { get; set; }    
    }
}
