using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char character = text[i];

                if (!occurrences.ContainsKey(character))
                {
                    occurrences.Add(character, 0);
                }
                occurrences[character]++;
            }

            foreach (var item in occurrences.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
