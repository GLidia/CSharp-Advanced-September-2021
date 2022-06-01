using System;
using System.Collections.Generic;

namespace _08_CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string power = input[1];

                if (input.Length == 2)
                {
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);
                }
                else if (input.Length == 4)
                {
                    double displacement = double.Parse(input[2]);
                    string efficiency = input[3];
                    Engine engine = new Engine(model, power, displacement, efficiency);
                    engines.Add(engine);
                }
                else if (input.Length == 3)
                {
                    string property = input[2];
                    double displacement;
                    bool isDisplacement = Double.TryParse(property, out displacement);

                    if (isDisplacement)
                    {
                        Engine engine = new Engine(model, power, displacement);
                        engines.Add(engine);
                    }
                    else
                    {
                        Engine engine = new Engine(model, power, property);
                        engines.Add(engine);
                    }

                }
            }

            int M = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < M; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                Engine engine;

                foreach (Engine engine1 in engines)
                {
                    if (engine1.Model == data[1])
                    {
                        engine = engine1;

                        if (data.Length == 2)
                        {
                            Car car = new Car(model, engine);
                            cars.Add(car);
                        } 
                        else if (data.Length == 3)
                        {
                            string property = data[2];
                            double weight;

                            bool isWeight = double.TryParse(property, out weight);

                            if (isWeight)
                            {
                                Car car = new Car(model, engine, weight);
                                cars.Add(car);
                            }
                            else
                            {
                                Car car = new Car(model, engine, property);
                                cars.Add(car);
                            }                                                         
                        }
                        else if (data.Length == 4)
                        {
                            Car car = new Car(model, engine, double.Parse(data[2]), data[3]);
                            cars.Add(car);
                        }

                    }
                }
               
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
