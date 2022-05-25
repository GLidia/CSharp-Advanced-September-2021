using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(array);
            List<int> even = new List<int>();

            while (queue.Count > 0)
            {
                int number = queue.Dequeue();

                if (number % 2 == 0)
                {
                    even.Add(number);
                }
            }

            Console.WriteLine(string.Join(", ", even));
        }
    }
}
