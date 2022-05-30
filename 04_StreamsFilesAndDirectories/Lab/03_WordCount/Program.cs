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
            Dictionary<string, int> occurrences = new Dictionary<string, int>();
            string[] separators = new string[] { "-", "?", " ", "!", ".", "," };

            StreamReader reader = new StreamReader("words.txt");
            using (reader)
            {
                string[] words = reader.ReadLine().Split();

                foreach (string word in words)
                {
                    occurrences.Add(word.ToLower(), 0);
                }
            }

            StreamReader newReader = new StreamReader("text.txt");
            using (newReader)
            {
                string line = newReader.ReadLine();

                while (line != null)
                {
                    string[] vocab = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string item in vocab)
                    {
                        if (occurrences.ContainsKey(item.ToLower()))
                        {
                            occurrences[item.ToLower()]++;
                        }
                    }
                    line = newReader.ReadLine();
                }
            }

            StreamWriter writer = new StreamWriter("result.txt");
            using (writer)
            {
                foreach (var word in occurrences.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key}-{word.Value}");
                }
            }
        }
    }
}
