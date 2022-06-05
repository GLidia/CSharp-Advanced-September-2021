using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Stack<int> bombCasings = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            int daturaCount = 0;
            int cherryCount = 0;
            int smokeDecoyCount = 0;
            bool isFull = false;

            while (bombEffects.Count > 0 && bombCasings.Count > 0)
            {
                int currentEffect = bombEffects.Peek();
                int currentCasing = bombCasings.Peek();

                if (currentEffect + currentCasing == 40)
                {
                    daturaCount++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else if (currentEffect + currentCasing == 60)
                {
                    cherryCount++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else if (currentEffect + currentCasing == 120)
                {
                    smokeDecoyCount++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else
                {
                    bombCasings.Pop();
                    bombCasings.Push(currentCasing - 5);
                }

                if (daturaCount >= 3 && cherryCount >= 3 && smokeDecoyCount >= 3)
                {
                    isFull = true;
                    break;
                }
            }

            if (isFull)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }

            if (bombCasings.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherryCount}");
            Console.WriteLine($"Datura Bombs: {daturaCount}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyCount}");
        }
    }
}
