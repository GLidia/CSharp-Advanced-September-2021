using System;
using System.Collections.Generic;

namespace _04_SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            for (int row = 0; row < N; row++)
            {
                char[] rowInput = Console.ReadLine().ToCharArray();

                for (int col = 0; col < N; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix ");
        }
    }
}
