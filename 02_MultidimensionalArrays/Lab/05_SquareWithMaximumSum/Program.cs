using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSizes[0], matrixSizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            int maxSum = int.MinValue;
            int[] topLeftCoordinates = new int[2];

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1] > maxSum)
                    {
                        maxSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                        topLeftCoordinates[0] = row;
                        topLeftCoordinates[1] = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[topLeftCoordinates[0], topLeftCoordinates[1]]} {matrix[topLeftCoordinates[0], topLeftCoordinates[1] + 1]}");
            Console.WriteLine($"{matrix[topLeftCoordinates[0] + 1, topLeftCoordinates[1]]} {matrix[topLeftCoordinates[0] + 1, topLeftCoordinates[1] + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
