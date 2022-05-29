using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //number + times of occurrence
            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!occurrences.ContainsKey(number))
                {
                    occurrences.Add(number, 0);
                }

                occurrences[number]++;
            }

            foreach (var item in occurrences.Where(x => x.Value % 2 == 0))
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
