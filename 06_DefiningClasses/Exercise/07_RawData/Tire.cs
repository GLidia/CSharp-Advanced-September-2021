﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07_RawData
{
    public class Tire
    { 
        public double Pressure { get; set; }
        public int Age { get; set; }

        public Tire(double pressure, int age)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
    }
}
