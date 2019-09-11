using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class WaterCraft
    {
        public int FuelCapacity { get; set; }
        public WaterCraftColor WaterCraftColor { get; set; }
        public int PassengerOccupancy { get; set; }
        public bool IsDriving { get; set; }


        public void Refuel()
        {
            var maxFuel = 100;
            if (FuelCapacity <= 100)
            {
                FuelCapacity++;
                Console.WriteLine("You have refueled you watercraft.");
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
                Console.WriteLine("Your watercraft is already driving.");
            }
            else if (!IsDriving)
            {
                Console.WriteLine("Your watercraft is now driving.");
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
