using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (command[0])
                {
                    case 1:
                        stack.Push(command[1]);
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            int largest = int.MinValue;

                            foreach (int number in stack)
                            {
                                if (number > largest)
                                {
                                    largest = number;
                                }
                            }

                            Console.WriteLine(largest);
                            //Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            int smallest = int.MaxValue;

                            foreach (int number in stack)
                            {
                                if (number < smallest)
                                {
                                    smallest = number;
                                }
                            }

                            Console.WriteLine(smallest);
                            //Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
