using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_DiagonalDifference
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

            int sumOne = 0;

            for (int i = 0; i < N; i++)
            {
                sumOne += matrix[i, i];
            }

            int sumTwo = 0;

            for (int i = 0; i < N; i++)
            {
                sumTwo += matrix[i, N - 1 - i];
            }

            Console.WriteLine(Math.Abs(sumOne - sumTwo));
        }
    }
}
