using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;
        public int Capacity { get; set; }

        public Clinic(int capacity)
        {
            Capacity = capacity;
            data = new List<Pet>();
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public Pet GetOldestPet()
        {
            if (data.Count == 0)
            {
                return null;
            }

            Pet oldestPet = data.OrderByDescending(x => x.Age).First();
            return oldestPet;
        }

        public Pet GetPet(string name, string owner)
        {
            if (data.Any(x => x.Name == name && x.Owner == owner))
            {
                return data.Where(x => x.Name == name && x.Owner == owner).First();
            }

            return null;
        }
        public bool Remove(string name)
        {
            if (data.Any(x => x.Name == name))
            {
                Pet petToRemove = data.Where(x => x.Name == name).First();
                data.Remove(petToRemove);
                return true;
            }

            return false;
        }

        public void Add(Pet pet)
        {
            if (data.Count < Capacity)
            {
                data.Add(pet);
            }
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");

            foreach (Pet pet in data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().Trim();
        }
    }
}
