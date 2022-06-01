using System;
using System.Collections.Generic;
using System.Text;

namespace _08_CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public string Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, string power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }

        public Engine(string model, string power, double displacement) : this(model, power)
        {
            this.Displacement = displacement.ToString();
        }

        public Engine(string model, string power, string efficiency) : this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, string power, double displacement, string efficiency) : this(model, power, displacement)
        {
            this.Efficiency = efficiency;
        }

    }
}
