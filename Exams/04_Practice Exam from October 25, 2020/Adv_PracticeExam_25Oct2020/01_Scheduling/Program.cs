using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            int taskToBeKilled = int.Parse(Console.ReadLine());
            int threadThatKilledIt = 0;

            while (true)
            {
                int lastTask = tasks.Peek();

                if (lastTask == taskToBeKilled)
                {
                    threadThatKilledIt = threads.Peek();
                    break;
                }

                int firstThread = threads.Peek();

                if (firstThread >= lastTask)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else if (firstThread < lastTask)
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine($"Thread with value {threadThatKilledIt} killed task {taskToBeKilled}");
            Console.WriteLine(string.Join((" "), threads));
        }
    }
}
