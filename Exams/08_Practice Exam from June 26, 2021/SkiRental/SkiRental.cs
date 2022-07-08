﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;
        public string Name { get; set; }
        public int Capacity { get; set; }

        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Ski>();
        }

        public int Count => data.Count;

        public void Add(Ski ski)
        {
            if (data.Count < Capacity)
            {
                data.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (data.Any(x => x.Manufacturer == manufacturer && x.Model == model))
            {
                Ski skiToRemove = data.Where(x => x.Manufacturer == manufacturer && x.Model == model).First();
                data.Remove(skiToRemove);
                return true;
            }
            return false;
        }

        public Ski GetNewestSki()
        {
            return data.OrderByDescending(x => x.Year).FirstOrDefault();
        }

        public Ski GetSki(string manufacturer, string model)
        {
            return data.Where(x => x.Manufacturer == manufacturer && x.Model == model).FirstOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {this.Name}:");
            foreach (Ski ski in data)
            {
                sb.AppendLine(ski.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
