using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSizes[0], matrixSizes[1]];

            for (int row = 0; row < matrixSizes[0]; row++)
            {
                int[] rowInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrixSizes[1]; col++)
                {

                    matrix[row, col] = rowInput[col];

                }
            }

            int sum = 0;
            foreach (int element in matrix)
            {
                sum += element;
            }

            Console.WriteLine(matrixSizes[0]);
            Console.WriteLine(matrixSizes[1]);
            Console.WriteLine(sum);
        }
    }
}
