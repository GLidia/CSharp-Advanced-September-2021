using System;
using System.Collections.Generic;
using System.Text;

namespace _08_CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, double weight) : this(model, engine)
        {
            this.Weight = weight.ToString();
        }

        public Car(string model, Engine engine, double weight, string color) : this(model, engine, weight)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            this.Color = color;
        }

        public override string ToString()
        {
            return $"{this.Model}:\n  {this.Engine.Model}:\n    Power: {this.Engine.Power}\n    Displacement: {this.Engine.Displacement}\n    Efficiency: {this.Engine.Efficiency}\n  Weight: {this.Weight}\n  Color: {this.Color}";
        }

    }
}
