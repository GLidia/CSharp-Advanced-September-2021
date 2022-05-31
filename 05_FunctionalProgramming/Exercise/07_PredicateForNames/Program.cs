using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Action<string, int> print = PrintIfShorter;

            foreach (string name in names)
            {
                print(name, n);
            }
        }

        private static void PrintIfShorter(string arg1, int arg2)
        {
            if (arg1.Length <= arg2)
            {
                Console.WriteLine(arg1);
            }
        }
    }
}
