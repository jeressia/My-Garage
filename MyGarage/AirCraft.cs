using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class AirCraft
    {
        public int FuelCapacity { get; set; }
        public AirCraftColor AirCraftColor { get; set; }
        public int PassengerOccupancy { get; set; }
        public bool IsFlying { get; set; }

        public void Refuel()
        {
            var maxFuel = 100;
            if (FuelCapacity <= 100)
            {
                FuelCapacity++;
                Console.WriteLine("You have refueled you aircraft.");
            }
            else if (FuelCapacity == maxFuel)
            {
                Console.WriteLine("You have a full tank.");
                return;
            }
        }

        public void Drive()
        {
            if (IsFlying)
            {
                Console.WriteLine("Your aircraft is already flying.");
            }
            else if (!IsFlying)
            {
                Console.WriteLine("Your aircraft is now flying.");
            }
        }

        public void Brake()
        {
            if (IsFlying)
            {
                Console.WriteLine("You are coming to a stop.");
            }
            else if (!IsFlying)
            {
                Console.WriteLine("You are not flying");
            }
        }
    }
}
