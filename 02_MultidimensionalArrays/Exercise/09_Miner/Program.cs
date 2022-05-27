using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();
            char[,] field = new char[N, N];
            int totalCoalCount = 0;
            int coalCollected = 0;
            int currentRow = 0;
            int currentCol = 0;

            for (int row = 0; row < N; row++)
            {
                char[] rowInput = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < N; col++)
                {
                    field[row, col] = rowInput[col];
                    
                    if (rowInput[col] == 'c')
                    {
                        totalCoalCount++;
                    }

                    if (rowInput[col] == 's')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                string command = commands[i];

                if (command == "left" && currentCol - 1 >= 0)
                {
                    currentCol -= 1;
                }
                else if (command == "right" && currentCol + 1 < N)
                {
                    currentCol += 1;
                }
                else if (command == "up" && currentRow - 1 >= 0)
                {
                    currentRow -= 1;
                }
                else if (command == "down" && currentRow + 1 < N)
                {
                    currentRow += 1;
                }
                else
                {
                    continue;
                }

                if (field[currentRow, currentCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
                else if (field[currentRow, currentCol] == '*')
                {
                    continue;
                }
                else if (field[currentRow, currentCol] == 'c')
                {
                    coalCollected++;
                    field[currentRow, currentCol] = '*';

                    if (coalCollected == totalCoalCount)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                }

            }

            Console.WriteLine($"{totalCoalCount - coalCollected} coals left. ({currentRow}, {currentCol})");

        }
    }
}
