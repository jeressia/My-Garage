using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles
{
    abstract class Vehicle
    {
        public int FuelCapacity { get; set; }
        public VehicleColor VehicleColor { get; set; }
        public int PassengerOccupancy { get; set; }
        public bool IsMoving { get; set; }


        public void Refuel()
        {
            var maxFuel = 100;
            if (FuelCapacity <= 100)
            {
                FuelCapacity++;
                Console.WriteLine("You have refueled you vehicle.");
            }
            else if (FuelCapacity == maxFuel)
            {
                Console.WriteLine("You have a full tank.");
                return;
            }
        }

        public void Drive()
        {
            if (IsMoving)
            {
                Console.WriteLine("Your vehicle is already moving.");
            }
            else if (!IsMoving)
            {
                Console.WriteLine("Your vehicle is now moving.");
                IsMoving = true;
            }
        }

        public void Brake()
        {
            if (IsMoving)
            {
                Console.WriteLine("You are coming to a stop.");
            }
            else if (!IsMoving)
            {
                Console.WriteLine("You are not moving.");
            }
        }
    }
}