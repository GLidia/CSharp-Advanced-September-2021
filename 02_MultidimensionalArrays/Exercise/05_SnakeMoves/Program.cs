using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[matrixSizes[0], matrixSizes[1]];
            char[] snake = Console.ReadLine().ToCharArray();

            int index = 0;

            for (int row = 0; row < matrixSizes[0]; row++)
            {
                for (int col = 0; col < matrixSizes[1]; col++)
                {
                    if (row % 2 == 0)
                    {
                        matrix[row, col] = snake[index % snake.Length];
                    }
                    else if (row % 2 == 1)
                    {
                        matrix[row, matrixSizes[1] - 1 - col] = snake[index % snake.Length];
                    }
                    index++;
                }

            }

            for (int row = 0; row < matrixSizes[0]; row++)
            {
                for (int col = 0; col < matrixSizes[1]; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
