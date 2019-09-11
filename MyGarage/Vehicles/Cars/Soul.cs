using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles.Cars
{
    class Soul : Vehicle
    {
        public Soul()
        {
            FuelCapacity = 50;
            VehicleColor = VehicleColor.Brown;
            PassengerOccupancy = 5;
        }
        public int NumberOfHamsters { get; set; }
        public bool HasMoonRoof { get; set; }
        public string DriverName { get; set; }

        public void HamsterParty()
        {
            if (NumberOfHamsters > 1)
            {
                Console.WriteLine($"There is a hamster party with {NumberOfHamsters} hamster(s) in this Kia Soul.");
            }
            else
            {
                Console.WriteLine($"There are no hamsters in this Kia Soul.");
            }
        }

        public void OpenMoonRoof()
        {
            Console.WriteLine("Ahh. A little fresh air.");
        }

        public void FastenSeatBelt(string DriverName)
        {
            Console.WriteLine($"{DriverName} just fastened her seatbelt");
        }
    }
}
