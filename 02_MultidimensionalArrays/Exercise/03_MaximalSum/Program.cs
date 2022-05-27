using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSizes[0], matrixSizes[1]];

            for (int row = 0; row < matrixSizes[0]; row++)
            {
                int[] rowInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrixSizes[1]; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            int maxSum = int.MinValue;
            int[] maxCoordinates = new int[2];

            for (int i = 0; i < matrixSizes[0] - 2; i++)
            {
                for (int j = 0; j < matrixSizes[1] - 2; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxCoordinates[0] = i;
                        maxCoordinates[1] = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[maxCoordinates[0] + i, maxCoordinates[1] + j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
