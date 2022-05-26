using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = numbers[0];
            int S = numbers[1];
            int X = numbers[2];
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());        

            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int smallest = int.MaxValue;
                while (stack.Count > 0)
                {
                    if (stack.Peek() == X)
                    {
                        Console.WriteLine("true");
                        return;
                    }
                    else if (stack.Peek() < smallest)
                    {
                        smallest = stack.Peek();
                    }

                    stack.Pop();
                }
                Console.WriteLine(smallest);
            }
        }
    }
}
