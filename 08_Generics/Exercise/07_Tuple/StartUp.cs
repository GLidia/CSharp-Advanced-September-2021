using System;
using System.Collections.Generic;

namespace _07_Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] nameAndAddress = Console.ReadLine().Split();
            string name = nameAndAddress[0] + " " + nameAndAddress[1];
            string address = nameAndAddress[2];

            for (int i = 3; i < nameAndAddress.Length; i++)
            {
                address += " " + nameAndAddress[i];
            }

            Tuple<string, string> tuple1 = new Tuple<string, string>(name, address);

            string[] nameAndBeer = Console.ReadLine().Split();
            string name2 = nameAndBeer[0];
            int beer = int.Parse(nameAndBeer[1]);

            Tuple<string, int> tuple2 = new Tuple<string, int>(name2, beer);

            string[] intAndDouble = Console.ReadLine().Split();
            int integer = int.Parse(intAndDouble[0]);
            double dbl = double.Parse(intAndDouble[1]);

            Tuple<int, double> tuple3 = new Tuple<int, double>(integer, dbl);

            Console.WriteLine($"{ tuple1.Item1} -> { tuple1.Item2}");
            Console.WriteLine($"{ tuple2.Item1} -> { tuple2.Item2}");
            Console.WriteLine($"{ tuple3.Item1} -> { tuple3.Item2}");
        }
    }
}
