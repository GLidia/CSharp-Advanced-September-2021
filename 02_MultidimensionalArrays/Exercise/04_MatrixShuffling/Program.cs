using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[matrixSizes[0], matrixSizes[1]];

            for (int row = 0; row < matrixSizes[0]; row++)
            {
                string[] rowInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrixSizes[1]; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (command[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);

                if (row1 < 0 || row1 >= matrixSizes[0] || row2 < 0 || row2 >= matrixSizes[0] || col1 < 0 || col1 >= matrixSizes[1] || col2 < 0 || col2 >= matrixSizes[1])
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string temp = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = temp;

                for (int row = 0; row < matrixSizes[0]; row++)
                {
                    for (int col = 0; col < matrixSizes[1]; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
