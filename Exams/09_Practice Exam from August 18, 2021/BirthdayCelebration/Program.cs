using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> guests = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> plates = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int foodWasted = 0;

            while (guests.Count > 0 && plates.Count > 0)
            {
                int currentGuest = guests.Peek();
                int currentPlate = plates.Peek();

                if (currentGuest > currentPlate)
                {
                    guests.Enqueue(guests.Dequeue() - currentPlate);
                    for (int i = 0; i < guests.Count - 1; i++)
                    {
                        guests.Enqueue(guests.Dequeue());
                    }
                    plates.Pop();
                }
                else if (currentPlate == currentGuest)
                {
                    guests.Dequeue();
                    plates.Pop();
                }
                else if (currentGuest < currentPlate)
                {
                    foodWasted += currentPlate - currentGuest;
                    guests.Dequeue();
                    plates.Pop();
                }
            }

            if (guests.Count == 0)
            {
                plates.Reverse();
                Console.WriteLine($"Plates: {string.Join(" ", plates)}");
            }
            else if (plates.Count == 0)
            {
                Console.WriteLine($"Guests: {string.Join(" ", guests)}");
            }

            Console.WriteLine($"Wasted grams of food: {foodWasted}");
        }
    }
}
