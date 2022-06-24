using System;
using System.Linq;

namespace _02_Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gardenDimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int N = gardenDimensions[0];
            int M = gardenDimensions[1];
            int[,] garden = new int[N, M];

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    garden[row, col] = 0;
                }
            }

            string input;

            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                string[] flowerCoordinates = input.Split();
                int flowerRow = int.Parse(flowerCoordinates[0]);
                int flowerCol = int.Parse(flowerCoordinates[1]);

                if (flowerRow < 0 || flowerRow >= N || flowerCol < 0 || flowerCol >= M)
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }

                for (int row = 0; row < N; row++)
                {
                    garden[row, flowerCol]++;
                }

                for (int col = 0; col < M; col++)
                {
                    garden[flowerRow, col]++;
                }

                garden[flowerRow, flowerCol]--;
            }

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    Console.Write(garden[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
