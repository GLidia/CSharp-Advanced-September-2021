using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Console.ReadLine().Split(" ").Select(char.Parse).ToArray());
            Stack<char> consonants = new Stack<char>(Console.ReadLine().Split(" ").Select(char.Parse).ToArray());

            Dictionary<string, HashSet<char>> words = new Dictionary<string, HashSet<char>>();
            words.Add("pear", new HashSet<char>());
            words.Add("flour", new HashSet<char>());
            words.Add("pork", new HashSet<char>());
            words.Add("olive", new HashSet<char>());

            while (consonants.Count > 0)
            {
                char currentVowel = vowels.Peek();
                char currentConsonant = consonants.Peek();

                if ("pear".Contains(currentVowel))
                {
                    words["pear"].Add(currentVowel);
                }
                
                if ("flour".Contains(currentVowel))
                {
                    words["flour"].Add(currentVowel);
                }

                if ("pork".Contains(currentVowel))
                {
                    words["pork"].Add(currentVowel);
                }

                if ("olive".Contains(currentVowel))
                {
                    words["olive"].Add(currentVowel);
                }

                if ("pear".Contains(currentConsonant))
                {
                    words["pear"].Add(currentConsonant);
                }

                if ("flour".Contains(currentConsonant))
                {
                    words["flour"].Add(currentConsonant);
                }

                if ("pork".Contains(currentConsonant))
                {
                    words["pork"].Add(currentConsonant);
                }

                if ("olive".Contains(currentConsonant))
                {
                    words["olive"].Add(currentConsonant);
                }

                vowels.Enqueue(vowels.Dequeue());
                consonants.Pop();
            }

            int wordsFound = 0;
                
            foreach (var item in words)
            {
                if (item.Key.Length == item.Value.Count)
                {
                    wordsFound++;
                }
            }

            Console.WriteLine($"Words found: { wordsFound} ");
            foreach (var item in words)
            {
                if (item.Key.Length == item.Value.Count)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
