using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Models
{
    class Car : Vheicle
    {
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        public Car(int year, string model,  double fuelCapacity,double fuelFor1km) : base(year)
        {
            Model = model;
            FuelCapacity = fuelCapacity;
            FuelFor1Km = fuelFor1km;
        }

        public void AddFuel(double fuel)
        {
            double canAddFuel = FuelCapacity - CurrentFuel;
            if (canAddFuel >= fuel)
            {
                CurrentFuel += fuel;
            }
            else
            {
                Console.WriteLine($"Maksimum Elave Ede Bileceyniz Miqdar {canAddFuel} Qederdir");
            }

        }

        public override void Drive(double km)
        {
            double candDrive = CurrentFuel / FuelFor1Km;

            if (candDrive >= km)
            {
                CurrentFuel -= (km * FuelFor1Km);
                Millage += km;
            }
            else
            {
                Console.WriteLine($"Maksimum Gede Bileceyin Yol {candDrive} Qederdir");
            }
        }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nFuelCapacity: {FuelCapacity}\nFuelFor1Km: {FuelFor1Km}\nCurrentFuel: {CurrentFuel}";
        }
    }
}
