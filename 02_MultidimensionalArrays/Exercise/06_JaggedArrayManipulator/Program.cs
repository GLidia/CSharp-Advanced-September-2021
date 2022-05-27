using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[][] jagged = new double[N][];

            for (int row = 0; row < N; row++)
            {
                jagged[row] = Console.ReadLine().Split().Select(double.Parse).ToArray();
            }

            for (int i = 0; i < N - 1; i++)
            {
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    for (int col = 0; col < jagged[i].Length; col++)
                    {
                        jagged[i][col] *= 2;
                        jagged[i + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col1 = 0; col1 < jagged[i].Length; col1++)
                    {
                        jagged[i][col1] /= 2;
                    }

                    for (int col2 = 0; col2 < jagged[i + 1].Length; col2++)
                    {
                        jagged[i + 1][col2] /= 2;
                    }
                }
            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                string action = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                double value = double.Parse(command[3]);

                if (row < 0 || row >= N || col < 0 || col >= jagged[row].Length)
                {
                    continue;
                }

                if (action == "Add")
                {
                    jagged[row][col] += value;
                }
                else if (action == "Subtract")
                {
                    jagged[row][col] -= value;
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(string.Join(" ", jagged[i]));
            }
        }
    }
}
