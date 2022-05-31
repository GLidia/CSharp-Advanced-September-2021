using System;
using System.Linq;

namespace _08_CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> order = SortOddEven;
            
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            numbers = order(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static int[] SortOddEven(int[] arg)
        {
            int[] odd = arg.Where(x => x % 2 != 0).ToArray();
            int[] even = arg.Where(x => x % 2 == 0).ToArray();

            Array.Sort(odd);
            Array.Sort(even);

            int[] result = new int[odd.Length + even.Length];

            for (int i = 0; i < even.Length; i++)
            {
                result[i] = even[i];
            }

            for (int i = 0; i < odd.Length; i++)
            {
                result[even.Length + i] = odd[i];
            }

            return result;
        }
    }
}
