using System;
using System.IO;

namespace _02_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Text.txt");

            int counter = 1;

            string[] linesToPrint = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                int letters = 0;
                int punctMarks = 0;

                foreach (char symbol in lines[i])
                {
                    if (Char.IsLetter(symbol))
                    {
                        letters++;
                    }
                    else if (Char.IsPunctuation(symbol))
                    {
                        punctMarks++;
                    }
                }

                string lineToPrint = $"Line {counter}: " + lines[i] + $"({letters})({punctMarks})";
                linesToPrint[i] = lineToPrint;
                counter++;
            }

            File.WriteAllLines("output.txt", linesToPrint);
        }
    }
}
