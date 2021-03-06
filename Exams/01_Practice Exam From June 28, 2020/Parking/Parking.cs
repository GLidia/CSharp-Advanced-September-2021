using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public string Type { get; set; }
        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return data.Count;
            }
        }

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }

        public void Add(Car car)
        {
            if (data.Count < Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (data.Any(x => x.Manufacturer == manufacturer && x.Model == model))
            {
                Car car = data.Where(x => x.Manufacturer == manufacturer && x.Model == model).First();
                data.Remove(car);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Car GetLatestCar()
        {
            if (data.Count == 0)
            {
                return null;
            }
            else
            {
                Car latestCar = data.OrderByDescending(x => x.Year).First();
                return latestCar;
            }
        }

        public Car GetCar(string manufacturer, string model)
        {
            if (data.Any(x => x.Manufacturer == manufacturer && x.Model == model))
            {
                Car car = data.Where(x => x.Manufacturer == manufacturer && x.Model == model).First();
                return car;
            }
            else
            {
                return null;
            }
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (Car car in data)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().Trim();
        }

    }
}
