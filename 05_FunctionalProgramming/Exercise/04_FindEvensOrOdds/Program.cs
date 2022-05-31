using System;
using System.Linq;

namespace _04_FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int smallest = range[0];
            int largest = range[1];
            string command = Console.ReadLine();

            Func<int, string, bool> checker = IsAppropriate;

            for (int i = smallest; i <= largest; i++)
            {
                if (checker(i, command))
                {
                    Console.Write(i + " ");
                }
            }
        }

        private static bool IsAppropriate(int n, string command)
        {
            if (command == "odd" && (n % 2 == 1 || n % 2 == -1))
            {
                return true;
            }
            else if (command == "even" && n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
