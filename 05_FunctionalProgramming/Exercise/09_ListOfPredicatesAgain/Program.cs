using System;
using System.Linq;

namespace _09_ListOfPredicatesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, int.Parse(Console.ReadLine()));
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int[], bool> isDivisibleByDividers = (x, dividers) =>
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

            numbers = numbers.Where(x => isDivisibleByDividers(x, dividers));
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
