using System;
using System.Collections.Generic;

namespace _07_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            long[][] triangle = new long[n][];
            triangle[0] = new long[1];
            triangle[0][0] = 1;

            for (int row = 1; row < n; row++)
            {
                triangle[row] = new long[row + 1];
                triangle[row][0] = 1;

                for (int col = 1; col < row + 1; col++)
                {
                    if (col == row)
                    {
                        triangle[row][col] = 1;
                    }
                    else
                    {
                        triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
                    }

                }
            }

            foreach (long[] row in triangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
