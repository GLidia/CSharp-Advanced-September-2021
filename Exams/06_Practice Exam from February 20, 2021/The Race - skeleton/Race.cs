using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public string Name { get; set; }
        public int Capacity { get; set; }

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Racer>();
        }

        public int Count => data.Count;

        public void Add(Racer racer)
        {
            if (data.Count < Capacity)
            {
                data.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            if (data.Any(x => x.Name == name))
            {
                Racer racerToRemove = data.Where(x => x.Name == name).First();
                data.Remove(racerToRemove);
                return true;
            }

            return false;
        }

        public Racer GetOldestRacer()
        {
            Racer oldestRacer = data.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestRacer;
        }

        public Racer GetRacer(string name)
        {
            Racer racer = data.Where(x => x.Name == name).FirstOrDefault();
            return racer;
        }

        public Racer GetFastestRacer()
        {
            Racer fastestRacer = data.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
            return fastestRacer;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {this.Name}:");
            foreach (Racer racer in data)
            {
                sb.AppendLine(racer.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
