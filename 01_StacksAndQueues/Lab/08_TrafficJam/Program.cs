using System;
using System.Collections.Generic;

namespace _08_TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int count = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < N; i++)
                    {
                        if (cars.Count > 0)
                        {
                            count++;
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
