using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _02_StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            foreach (int item in integers)
            {
                stack.Push(item);
            }

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] command = input.Split();

                if (command[0].ToLower() == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (command[0].ToLower() == "remove")
                {
                    int countToRemove = int.Parse(command[1]);
                    if (countToRemove <= stack.Count)
                    {
                        for (int i = 0; i < countToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                input = Console.ReadLine();
            }

            BigInteger sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
