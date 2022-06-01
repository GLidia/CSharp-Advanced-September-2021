using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public List<Car> Cars 
        {
            get { return this.cars; }
            set { this.cars = value; }
        }

        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }

        public int Count
        {
            get { return this.cars.Count; }
            set { this.Count = this.cars.Count; }
        }

        public Parking(int capacity)
        {
            this.Cars = new List<Car>();
            this.capacity = capacity;
        }

        public string AddCar(Car car)
        {
            if (this.Cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (this.Cars.Count == this.capacity)
            {
                return "Parking is full!";
            }
            else
            {
                this.Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!this.Cars.Any(x => x.RegistrationNumber == registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                
                this.Cars.RemoveAll(x => x.RegistrationNumber == registrationNumber);
                
                return $"Successfully removed {registrationNumber}";
            }

        }

        public Car GetCar(string registrationNumber)
        {
            return this.Cars.Where(x => x.RegistrationNumber == registrationNumber).FirstOrDefault();
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string number in registrationNumbers)
            {
                if (this.Cars.Any(x => x.RegistrationNumber == number))
                {
                    Predicate<Car> hasNumber = x => x.RegistrationNumber == number;
                    this.Cars.RemoveAll(hasNumber);
                }

            }
        }

    }
}
