using System;
using System.Collections.Generic;

namespace _10_Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();
            int durationOfGreen = int.Parse(Console.ReadLine());
            int durationOfWindow = int.Parse(Console.ReadLine());
            int count = 0;
            int timeAvailableToEnter = 0;
            int timeAvailableToLeave = 0;
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (input == "green")
                {
                    timeAvailableToEnter = durationOfGreen;
                    timeAvailableToLeave = durationOfWindow;

                    while (cars.Count > 0 && timeAvailableToEnter > 0)
                    {
                        if (timeAvailableToEnter >= cars.Peek().Length)
                        {
                            count++;
                            timeAvailableToEnter -= cars.Peek().Length;
                            cars.Dequeue();

                        }
                        else if (timeAvailableToEnter > 0 && timeAvailableToEnter < cars.Peek().Length && timeAvailableToEnter + timeAvailableToLeave >= cars.Peek().Length)
                        {
                            count++;
                            timeAvailableToEnter = 0;
                            cars.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{cars.Peek()} was hit at {cars.Peek()[timeAvailableToEnter + timeAvailableToLeave]}.");
                            return;
                        }
                    }

                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{count} total cars passed the crossroads.");
        }
    }
}
