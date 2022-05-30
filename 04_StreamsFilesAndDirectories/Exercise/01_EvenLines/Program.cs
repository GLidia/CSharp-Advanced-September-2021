using System;
using System.IO;

namespace _01_EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Text.txt");
            
            using(reader)
            {
                string line = reader.ReadLine();
                int counter = 0;

                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                        string textToPrint = string.Empty;

                        for (int i = 0; i < line.Length; i++)
                        {
                            char symbol = line[i];

                            if (symbol == ',' || symbol == '.' || symbol == '!' || symbol == '?' || symbol == '-')
                            {
                                textToPrint += "@";
                            }
                            else
                            {
                                textToPrint += symbol;
                            }
                        }

                        string[] words = textToPrint.Split();
                        Array.Reverse(words);
                        
                        Console.WriteLine(string.Join(" ", words));
                    }

                    line = reader.ReadLine();
                    counter++;
                }
            }
        }
    }
}
