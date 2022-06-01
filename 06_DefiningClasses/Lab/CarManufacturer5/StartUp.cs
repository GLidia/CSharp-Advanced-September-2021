using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input;
            List<Tire[]> tireList = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] info = input.Split();

                Tire[] newTires = new Tire[4]
                {
                    new Tire(int.Parse(info[0]), double.Parse(info[1])),
                    new Tire(int.Parse(info[2]), double.Parse(info[3])),
                    new Tire(int.Parse(info[4]), double.Parse(info[5])),
                    new Tire(int.Parse(info[6]), double.Parse(info[7])),
                };

                tireList.Add(newTires);
            }

            string inputTwo;

            while ((inputTwo = Console.ReadLine()) != "Engines done")
            {
                string[] engineData = inputTwo.Split();
                int horsePower = int.Parse(engineData[0]);
                double cubicCapacity = double.Parse(engineData[1]);
                Engine newEngine = new Engine(horsePower, cubicCapacity);
                engines.Add(newEngine);
            }

            string inputThree;

            List<Car> cars = new List<Car>();

            while ((inputThree = Console.ReadLine()) != "Show special")
            {
                string[] data = inputThree.Split();
                Engine engine = engines[int.Parse(data[5])];
                Tire[] tires = tireList[int.Parse(data[6])];
                Car car = new Car(data[0], data[1], int.Parse(data[2]), double.Parse(data[3]), double.Parse(data[4]), engine, tires);
                cars.Add(car);
            }

            foreach (Car car in cars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330))
            {
                double sumPressure = 0;
                foreach (Tire tire in car.Tires)
                {
                    sumPressure += tire.Pressure;
                }

                if (sumPressure < 10 && sumPressure > 9)
                {
                    car.Drive(20);
                    Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
                }
            }

        }
    }
}
