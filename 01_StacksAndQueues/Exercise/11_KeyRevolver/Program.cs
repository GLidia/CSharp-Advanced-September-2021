using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> locks = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray().Reverse());
            int intelligenceValue = int.Parse(Console.ReadLine());
            int bulletsUsedCount = 0;

            while (locks.Count > 0 && bullets.Count > 0)
            {
                if (bullets.Peek() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Pop();
                    bullets.Pop();
                }
                else if (bullets.Peek() > locks.Peek())
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                }

                bulletsUsedCount++;
                if (bullets.Count > 0 && bulletsUsedCount % gunBarrelSize == 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (locks.Count == 0)
            {
                int bulletsLeft = bullets.Count;
                int moneyEarned = intelligenceValue - (bulletsUsedCount * bulletPrice);
                Console.WriteLine($"{bulletsLeft} bullets left. Earned ${moneyEarned}");
            }
            else if (bullets.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
