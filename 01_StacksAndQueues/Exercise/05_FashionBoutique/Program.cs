using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int rackCapacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int rackCount = 0;

            while (true)
            {
                if (clothes.Count == 0)
                {
                    break;
                }

                if (sum + clothes.Peek() <= rackCapacity)
                {
                    sum += clothes.Pop();

                    if (clothes.Count == 0)
                    {
                        rackCount++;
                        break;
                    }
                }
                else
                {
                    rackCount++;
                    sum = 0;
                }
            }

            Console.WriteLine(rackCount);
        }
    }
}
