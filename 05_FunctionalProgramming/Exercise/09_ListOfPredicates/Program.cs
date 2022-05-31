using System;
using System.Linq;

namespace _09_ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Predicate<int> isDivisible = x =>
            {
                foreach (int divider in dividers)
                {
                    if (x % divider != 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            for (int i = 1; i <= N; i++)
            {
                if (isDivisible(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
