using System;
using System.Linq;

namespace _03_CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> findMin = GetMin;

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(findMin(numbers));
                
        }

        private static int GetMin(int[] arg)
        {
            int minNumber = int.MaxValue;

            foreach (int number in arg)
            {
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            return minNumber;
        }
    }
}
