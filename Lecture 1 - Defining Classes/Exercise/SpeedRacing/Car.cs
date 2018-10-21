using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
   public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKm;
        private double distance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.distance = 0;
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public string Model
        {
            get { return this.model; }
        }

        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }
        }

        public double Distance
        {
            get
            {
                return this.distance;
            }
        }

        public void Drive(int km)
        {
            double fuelNeeded = km * fuelConsumptionPerKm;
            if (fuelAmount >= fuelNeeded)
            {
                fuelAmount -= fuelNeeded;
                distance += km;
                //return true;
            }
            else
            {   //no enough fuel
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }
}
