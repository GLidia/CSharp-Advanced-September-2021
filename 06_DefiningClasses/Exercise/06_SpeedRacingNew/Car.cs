using System;
using System.Collections.Generic;
using System.Text;

namespace _06_SpeedRacingNew
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
            this.TravelledDistance = 0;
        }

        public void Drive(double distance)
        {
            if (this.FuelAmount - (this.FuelConsumptionPerKilometer * distance) >= 0)
            {
                this.TravelledDistance += distance;
                this.FuelAmount -= this.FuelConsumptionPerKilometer * distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
