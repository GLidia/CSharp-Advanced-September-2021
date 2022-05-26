using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_PrimaryDiagonal
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

            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
