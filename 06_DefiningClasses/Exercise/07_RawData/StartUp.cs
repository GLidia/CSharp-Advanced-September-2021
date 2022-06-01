using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_RawData
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
                Car car = new Car(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), input[4], double.Parse(input[5]), int.Parse(input[6]), double.Parse(input[7]), int.Parse(input[8]), double.Parse(input[9]), int.Parse(input[10]), double.Parse(input[11]), int.Parse(input[12]));
                cars.Add(car);
            }

            string cargoType = Console.ReadLine();

            if (cargoType == "fragile")
            {
                foreach (Car car in cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(x => x.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (cargoType == "flammable")
            {
                foreach (Car car in cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }

        }
    }
}
