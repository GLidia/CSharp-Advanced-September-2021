using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            for (int row = 0; row < N; row++)
            {
                int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < N; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            string[] coordinates = Console.ReadLine().Split();

            foreach (string item in coordinates)
            {
                int[] data = item.Split(",").Select(int.Parse).ToArray();
                int row = data[0];
                int col = data[1];

                int bombValue = matrix[row, col];

                if (bombValue <= 0)
                {
                    continue;
                }
                matrix[row, col] = 0;

                if (row - 1 >= 0 && col - 1 >= 0 && matrix[row - 1, col - 1] > 0)
                {
                    matrix[row - 1, col - 1] -= bombValue;
                }

                if (row - 1 >= 0 && matrix[row - 1, col] > 0)
                {
                    matrix[row - 1, col] -= bombValue;
                }

                if (row - 1 >= 0 && col + 1 < N && matrix[row - 1, col + 1] > 0)
                {
                    matrix[row - 1, col + 1] -= bombValue;
                }

                if (col - 1 >= 0 && matrix[row, col - 1] > 0)
                {
                    matrix[row, col - 1] -= bombValue;
                }

                if (col + 1 < N && matrix[row, col + 1] > 0)
                {
                    matrix[row, col + 1] -= bombValue;
                }

                if (row + 1 < N && col - 1 >= 0 && matrix[row + 1, col - 1] > 0)
                {
                    matrix[row + 1, col - 1] -= bombValue;
                }

                if (row + 1 < N && matrix[row + 1, col] > 0)
                {
                    matrix[row + 1, col] -= bombValue;
                }

                if (row + 1 < N && col + 1 < N && matrix[row + 1, col + 1] > 0)
                {
                    matrix[row + 1, col + 1] -= bombValue;
                }
            }

            int aliveCellsCount = 0;
            long aliveCellsSum = 0;

            foreach (var element in matrix)
            {
                if (element > 0)
                {
                    aliveCellsCount++;
                    aliveCellsSum += element;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {aliveCellsSum}");

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
