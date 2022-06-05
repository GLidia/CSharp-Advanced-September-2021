using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            int storedFlowers = 0;
            int wreathsMade = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int currentLily = lilies.Peek();
                int currentRose = roses.Peek();

                if (currentLily + currentRose == 15)
                {
                    wreathsMade++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (currentLily + currentRose > 15)
                {
                    lilies.Pop();
                    lilies.Push(currentLily - 2);
                }
                else if (currentLily + currentRose < 15)
                {
                    storedFlowers += currentLily + currentRose;
                    lilies.Pop();
                    roses.Dequeue();
                }
            }

            wreathsMade += (storedFlowers / 15);

            if (wreathsMade >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsMade} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathsMade} wreaths more!");
            }
        }
    }
}
