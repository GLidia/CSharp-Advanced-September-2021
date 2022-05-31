using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_CustomComparatorAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparer<int> comparer = Comparer<int>.Create((x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }
                else if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }
                else if (x > y)
                {
                    return 1;
                }
                else if (x < y)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            });

            
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(numbers, comparer);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
