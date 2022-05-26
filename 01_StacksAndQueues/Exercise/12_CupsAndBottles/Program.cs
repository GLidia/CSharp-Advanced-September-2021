using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> cups = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray().Reverse());
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int wastedWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                if (bottles.Peek() < cups.Peek())
                {
                    cups.Push(cups.Pop() - bottles.Pop());
                }
                else if (bottles.Peek() >= cups.Peek())
                {
                    wastedWater += bottles.Pop() - cups.Pop();
                }
            }

            if (cups.Count == 0)
            {
                int[] bottlesArray = bottles.ToArray();
                bottlesArray.Reverse();
                Console.WriteLine($"Bottles: {string.Join(" ", bottlesArray)}");
            }

            if (bottles.Count == 0)
            {
                int[] cupsArray = cups.ToArray();
                cupsArray.Reverse();
                Console.WriteLine($"Cups: {string.Join(" ", cupsArray)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
