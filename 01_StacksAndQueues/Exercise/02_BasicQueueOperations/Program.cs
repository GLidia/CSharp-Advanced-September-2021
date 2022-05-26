using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int S = input[1];
            int X = input[2];

            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }

            int smallest = int.MaxValue;

            if (queue.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }

            while (queue.Count > 0)
            {
                int number = queue.Dequeue();

                if (number == X)
                {
                    Console.WriteLine("true");
                    return;
                }
                else if (number < smallest)
                {
                    smallest = number;
                }
            }

            Console.WriteLine(smallest);
        }
    }
}
