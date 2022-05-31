using System;
using System.Linq;

namespace _04_AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> addingVAT = x => x * 1.20;
            double[] prices = Console.ReadLine().Split(", ").Select(double.Parse).Select(addingVAT).ToArray();
            foreach (double price in prices)
            {
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}
