using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        private List<Car> Participants;

        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }

        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
            Participants = new List<Car>();
        }

        public int Count => Participants.Count;

        public void Add(Car car)
        {
            if (!Participants.Any(x => x.LicensePlate == car.LicensePlate) && Participants.Count < Capacity && car.HorsePower <= MaxHorsePower)
            {
                Participants.Add(car);
            }
        }

        public bool Remove(string licensePlate)
        {
            if (Participants.Any(x => x.LicensePlate == licensePlate))
            {
                Car carToRemove = Participants.Where(x => x.LicensePlate == licensePlate).First();
                Participants.Remove(carToRemove);
                return true;
            }
            return false;
        }

        public Car FindParticipant(string licensePlate)
        {
            return Participants.Where(x => x.LicensePlate == licensePlate).FirstOrDefault();
        }

        public Car GetMostPowerfulCar()
        {
            return Participants.OrderByDescending(x => x.HorsePower).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (Car car in Participants)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
