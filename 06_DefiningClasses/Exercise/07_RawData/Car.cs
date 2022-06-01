using System;
using System.Collections.Generic;
using System.Text;

namespace _07_RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string model, int speed, int power, int weight, string type, double pressure1, int age1, double pressure2, int age2, double pressure3, int age3, double pressure4, int age4)
        {
            this.Model = model;
            this.Engine = new Engine(speed, power);
            this.Cargo = new Cargo(weight, type);

            Tire tire1 = new Tire(pressure1, age1);
            Tire tire2 = new Tire(pressure2, age2);
            Tire tire3 = new Tire(pressure3, age3);
            Tire tire4 = new Tire(pressure4, age4);

            this.Tires = new Tire[]
            {
                tire1,
                tire2,
                tire3,
                tire4,
            };
        }
    }
}
