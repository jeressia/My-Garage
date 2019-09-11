using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    abstract class Car
    {
        public int FuelCapacity { get; set; }
        public CarColor CarColor { get; set; }
        public int PassengerOccupancy { get; set; }
        public bool IsDriving { get; set; }


        public void Refuel()
        {
            var maxFuel = 100;
            if (FuelCapacity <= 100)
            {
                FuelCapacity++;
                Console.WriteLine("You have refueled you car.");
            }
            else if (FuelCapacity == maxFuel)
            {
                Console.WriteLine("You have a full tank.");
                return;
            }
        }

        public void Drive()
        {
            if (IsDriving)
            {
                Console.WriteLine("Your car is already driving.");
            }
            else if (!IsDriving)
            {
                Console.WriteLine("Your car is now driving.");
            }
        }

        public void Brake()
        {
            if (IsDriving)
            {
                Console.WriteLine("You are coming to a stop.");
            }
            else if (!IsDriving)
            {
                Console.WriteLine("You are not driving");
            }
        }
    }
}
