using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> count = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double number = numbers[i];

                if (!count.ContainsKey(number))
                {
                    count.Add(number, 0);
                }
                count[number]++;
                    
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
