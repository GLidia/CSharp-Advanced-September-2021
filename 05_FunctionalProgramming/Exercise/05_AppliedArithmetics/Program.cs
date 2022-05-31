using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;

            Action<List<int>> print = inputList => Console.WriteLine(string.Join(" ", inputList));
            Func<int, int> add = x => x + 1;
            Func<int, int> multiply = x => x * 2;
            Func<int, int> subtract = x => x - 1;

            while ((input = Console.ReadLine()) != "end")
            {
                switch (input)
                {
                    case "add":
                        numbers = numbers.Select(add).ToList();
                        break;
                    case "multiply":
                        numbers = numbers.Select(multiply).ToList();
                        break;
                    case "subtract":
                        numbers = numbers.Select(subtract).ToList();
                        break;
                    case "print":
                        print(numbers);
                        break;
                }
            }

        }
    }
}
