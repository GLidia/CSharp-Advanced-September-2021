using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(", ");
                string action = command[0];
                string car = command[1];

                if (action == "IN")
                {
                    cars.Add(car);
                }
                else if (action == "OUT")
                {
                    cars.Remove(car);
                }
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
