using System;
using System.Collections.Generic;

namespace _06_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> names = new Queue<string>();
            
            while (input != "End")
            {
                if (input != "Paid")
                {
                    names.Enqueue(input);
                }
                else
                {
                    Console.WriteLine(string.Join("\n", names));
                    names.Clear();
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
