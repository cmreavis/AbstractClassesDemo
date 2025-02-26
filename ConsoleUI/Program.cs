﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List<Vehicle> vehicles = new List<Vehicle>();


            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car whiteCar = new Car()
            {
                Year = "2020",
                Make = "Mazda",
                Model = "Hatchback",
                numDoors = 5,
            };
            vehicles.Add(whiteCar);

            Motorcycle sportBike = new Motorcycle()
            { 
                Year = "2017", 
                Make = "Yamaha", 
                Model = "R6", 
                hasSidecar = false
            };
            vehicles.Add(sportBike);

            Vehicle smartCar = new Car()
            {
                Year = "2015",
                Make = "Smart",
                Model = "SmartCar",
                numDoors = 5,
            };
            vehicles.Add(smartCar);

            Vehicle tricycle = new Motorcycle()
            {
                Year = "2019",
                Make = "Polaris",
                Model = "Slingshot",
                hasSidecar = true,
            };
            vehicles.Add(tricycle);


            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"Year:{vehicle.Year} \nMake:{vehicle.Make} \nModel:{vehicle.Model}");
                Console.WriteLine();
            }


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            whiteCar.DriveAbstract();
            sportBike.DriveAbstract();
            smartCar.DriveAbstract();
            tricycle.DriveAbstract();


            #endregion            
            Console.ReadLine();
        }
    }
}
