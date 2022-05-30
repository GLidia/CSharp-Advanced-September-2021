using System;
using System.IO;

namespace _02_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Input.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                int count = 1;

                StreamWriter writer = new StreamWriter("Output.txt");
                using (writer)
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{count}. {line}");

                        line = reader.ReadLine();
                        count++;
                    }
                }
            }
        }
    }
}
