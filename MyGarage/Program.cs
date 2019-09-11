using MyGarage.Vehicles.Cars;
using System;

namespace MyGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = "Jeressia";

            var myCar = new Soul();

            myCar.FastenSeatBelt(driver);
            myCar.NumberOfHamsters = 26;

            myCar.HamsterParty();
            myCar.Drive();
            myCar.Brake();

        }
    }
}
