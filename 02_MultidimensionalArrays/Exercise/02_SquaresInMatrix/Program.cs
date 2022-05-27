using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[matrixSizes[0], matrixSizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            int count = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {

                    char current = matrix[i, j];
                    if (current == matrix[i, j + 1] && current == matrix[i + 1, j] && current == matrix[i + 1, j + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
