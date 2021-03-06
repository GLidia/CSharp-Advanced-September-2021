using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            //Console.WriteLine(orders.Max());
            int largestOrder = int.MinValue;
            foreach (int order in orders)
            {
                if (order > largestOrder)
                {
                    largestOrder = order;
                }
            }
            Console.WriteLine(largestOrder);

            // while (foodQuantity > 0)
            while (true)
            {
                if (orders.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    return;
                }
                else
                {
                    if (foodQuantity >= orders.Peek())
                    {
                        foodQuantity -= orders.Dequeue();
                        if (foodQuantity == 0)
                        {
                            Console.WriteLine("Orders complete");
                            return;
                        }
                    }
                    else
                    {
                        break;
                    }

                }
            }

            Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
        }
    }
}
