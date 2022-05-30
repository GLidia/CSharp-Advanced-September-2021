using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("Words.txt");
            string[] wordsInText = File.ReadAllText("Text.txt").Split(new string[] { ",", " ", ".", "!", "?", "-" }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> repetitions = new Dictionary<string, int>();

            foreach (string word in words)
            {
                repetitions.Add(word, 0);

                foreach (var item in wordsInText)
                {

                    if (word.ToLower() == item.ToLower())
                    {
                        repetitions[word]++;
                    }
                }
            }

            string[] linesToPrint = new string[words.Length];
            int counter = 0;

            foreach (var item in repetitions.OrderByDescending(x => x.Value))
            {
                string line = $"{item.Key} - {item.Value}";
                linesToPrint[counter] = line;
                counter++;
            }

            File.WriteAllLines("actualResults.txt", linesToPrint);

            
        }
    }
}
