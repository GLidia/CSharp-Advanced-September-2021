using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_SpeedRacingNew
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuel = double.Parse(input[1]);
                double consumption = double.Parse(input[2]);

                Car car = new Car(model, fuel, consumption);
                cars.Add(car);
            }

            string inputTwo;

            while ((inputTwo = Console.ReadLine()) != "End")
            {
                string[] command = inputTwo.Split();
                string model = command[1];
                double km = double.Parse(command[2]);

                foreach (Car car in cars.Where(x => x.Model == model))
                {
                    car.Drive(km);
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
