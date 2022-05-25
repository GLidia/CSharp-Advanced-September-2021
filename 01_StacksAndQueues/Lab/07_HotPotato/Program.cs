using System;
using System.Collections.Generic;

namespace _07_HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> children = new Queue<string>(Console.ReadLine().Split());
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            while (children.Count > 1)
            {
                count++;
                if (count % n == 0)
                {
                    Console.WriteLine($"Removed {children.Dequeue()}");
                }
                else
                {
                    children.Enqueue(children.Dequeue());
                }
            }

            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
