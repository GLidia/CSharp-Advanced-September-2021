using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // color + (item + count)
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();
            string[] separators = new string[] { ",", " -> " };

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];

                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1; j < input.Length; j++)
                {
                    string item = input[j];

                    if (!clothes[color].ContainsKey(item))
                    {
                        clothes[color].Add(item, 0);
                    }
                    clothes[color][item]++;
                }
            }

            string[] itemToLookFor = Console.ReadLine().Split();
            string colorToLookFor = itemToLookFor[0];
            string exactItemToLookFor = itemToLookFor[1];

            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var (item, count) in color.Value)
                {
                    if (color.Key == colorToLookFor && item == exactItemToLookFor)
                    {
                        Console.WriteLine($"* {item} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item} - {count}");
                    }
                }
            }
        }
    }
}
