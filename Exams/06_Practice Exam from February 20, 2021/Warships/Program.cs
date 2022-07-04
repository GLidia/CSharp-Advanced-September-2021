using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            // 90/100
            long n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            List<string> attackInput = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
            Queue<long[]> attacks = new Queue<long[]>();
            BigInteger playerOneTotalShips = 0;
            BigInteger playerTwoTotalShips = 0;
            for (int i = 0; i < attackInput.Count; i++)
            {
                long[] coordinates = attackInput[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
                attacks.Enqueue(coordinates);
            }
            for (int row = 0; row < n; row++)
            {
                char[] rowInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowInput[col];
                    if (rowInput[col] == '<')
                    {
                        playerOneTotalShips++;
                    }
                    else if (rowInput[col] == '>')
                    {
                        playerTwoTotalShips++;
                    }
                }
            }
            long attackCount = 0;
            BigInteger shipsDrownedByPlayerOne = 0;
            BigInteger shipsDrownedByPlayerTwo = 0;
            bool allShipsOfPlayerOneDrowned = false;
            bool allShipsOfPlayerTwoDrowned = false;
            while (attacks.Count > 0)
            {
                attackCount++;
                long[] currentCoordinates = attacks.Dequeue();
                long currentRow = currentCoordinates[0];
                long currentCol = currentCoordinates[1];

                if (currentRow < 0 || currentRow >= n || currentCol < 0 || currentCol >= n)
                {
                    continue;
                }

                if (attackCount % 2 == 1)
                {
                    if (matrix[currentRow, currentCol] == '>')
                    {
                        matrix[currentRow, currentCol] = 'X';
                        shipsDrownedByPlayerOne++;
                    }
                    else if (matrix[currentRow, currentCol] == '#')
                    {
                        matrix[currentRow, currentCol] = 'X';
                        if (currentRow - 1 >= 0 && currentCol - 1 >= 0)
                        {
                            if (matrix[currentRow - 1, currentCol - 1] == '<')
                            {
                                matrix[currentRow - 1, currentCol - 1] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow - 1, currentCol - 1] == '>')
                            {
                                matrix[currentRow - 1, currentCol - 1] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentRow + 1 < n && currentCol + 1 < n)
                        {
                            if (matrix[currentRow + 1, currentCol + 1] == '<')
                            {
                                matrix[currentRow + 1, currentCol + 1] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow + 1, currentCol + 1] == '>')
                            {
                                matrix[currentRow + 1, currentCol + 1] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentRow - 1 >= 0 && currentCol + 1 < n)
                        {
                            if (matrix[currentRow - 1, currentCol + 1] == '<')
                            {
                                matrix[currentRow - 1, currentCol + 1] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow - 1, currentCol + 1] == '>')
                            {
                                matrix[currentRow - 1, currentCol + 1] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentRow + 1 < n && currentCol - 1 >= 0)
                        {
                            if (matrix[currentRow + 1, currentCol - 1] == '<')
                            {
                                matrix[currentRow + 1, currentCol - 1] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow + 1, currentCol - 1] == '>')
                            {
                                matrix[currentRow + 1, currentCol - 1] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentRow - 1 >= 0)
                        {
                            if (matrix[currentRow - 1, currentCol] == '<')
                            {
                                matrix[currentRow - 1, currentCol] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow - 1, currentCol] == '>')
                            {
                                matrix[currentRow - 1, currentCol] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentRow + 1 < n)
                        {
                            if (matrix[currentRow + 1, currentCol] == '<')
                            {
                                matrix[currentRow + 1, currentCol] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow + 1, currentCol] == '>')
                            {
                                matrix[currentRow + 1, currentCol] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentCol + 1 < n)
                        {
                            if (matrix[currentRow, currentCol + 1] == '<')
                            {
                                matrix[currentRow, currentCol + 1] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow, currentCol + 1] == '>')
                            {
                                matrix[currentRow, currentCol + 1] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentCol - 1 >= 0)
                        {
                            if (matrix[currentRow, currentCol - 1] == '<')
                            {
                                matrix[currentRow, currentCol - 1] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow, currentCol - 1] == '>')
                            {
                                matrix[currentRow, currentCol - 1] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                    }
                }
                else if (attackCount % 2 == 0)
                {
                    //player Two is attacking
                    if (matrix[currentRow, currentCol] == '<')
                    {
                        matrix[currentRow, currentCol] = 'X';
                        shipsDrownedByPlayerTwo++;
                    }
                    else if (matrix[currentRow, currentCol] == '#')
                    {
                        matrix[currentRow, currentCol] = 'X';

                        if (currentRow - 1 >= 0 && currentCol - 1 >= 0)
                        {
                            if (matrix[currentRow - 1, currentCol - 1] == '<')
                            {
                                matrix[currentRow - 1, currentCol - 1] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow - 1, currentCol - 1] == '>')
                            {
                                matrix[currentRow - 1, currentCol - 1] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentRow + 1 < n && currentCol + 1 < n)
                        {
                            if (matrix[currentRow + 1, currentCol + 1] == '<')
                            {
                                matrix[currentRow + 1, currentCol + 1] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow + 1, currentCol + 1] == '>')
                            {
                                matrix[currentRow + 1, currentCol + 1] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentRow - 1 >= 0 && currentCol + 1 < n)
                        {
                            if (matrix[currentRow - 1, currentCol + 1] == '<')
                            {
                                matrix[currentRow - 1, currentCol + 1] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow - 1, currentCol + 1] == '>')
                            {
                                matrix[currentRow - 1, currentCol + 1] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentRow + 1 < n && currentCol - 1 >= 0)
                        {
                            if (matrix[currentRow + 1, currentCol - 1] == '<')
                            {
                                matrix[currentRow + 1, currentCol - 1] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow + 1, currentCol - 1] == '>')
                            {
                                matrix[currentRow + 1, currentCol - 1] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentRow - 1 >= 0)
                        {
                            if (matrix[currentRow - 1, currentCol] == '<')
                            {
                                matrix[currentRow - 1, currentCol] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow - 1, currentCol] == '>')
                            {
                                matrix[currentRow - 1, currentCol] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentRow + 1 < n)
                        {
                            if (matrix[currentRow + 1, currentCol] == '<')
                            {
                                matrix[currentRow + 1, currentCol] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow + 1, currentCol] == '>')
                            {
                                matrix[currentRow + 1, currentCol] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentCol + 1 < n)
                        {
                            if (matrix[currentRow, currentCol + 1] == '<')
                            {
                                matrix[currentRow, currentCol + 1] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow, currentCol + 1] == '>')
                            {
                                matrix[currentRow, currentCol + 1] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }

                        if (currentCol - 1 >= 0)
                        {
                            if (matrix[currentRow, currentCol - 1] == '<')
                            {
                                matrix[currentRow, currentCol - 1] = 'X';
                                shipsDrownedByPlayerTwo++;
                            }
                            else if (matrix[currentRow, currentCol - 1] == '>')
                            {
                                matrix[currentRow, currentCol - 1] = 'X';
                                shipsDrownedByPlayerOne++;
                            }
                        }
                    }
                }

                if (shipsDrownedByPlayerOne == playerTwoTotalShips)
                {
                    allShipsOfPlayerTwoDrowned = true;
                    break;
                }

                if (shipsDrownedByPlayerTwo == playerOneTotalShips)
                {
                    allShipsOfPlayerOneDrowned = true;
                    break;
                }
            }

            if (allShipsOfPlayerTwoDrowned)
            {
                Console.WriteLine($"Player One has won the game! {shipsDrownedByPlayerOne + shipsDrownedByPlayerTwo} ships have been sunk in the battle.");
            }
            else if (allShipsOfPlayerOneDrowned)
            {
                Console.WriteLine($"Player Two has won the game! {shipsDrownedByPlayerOne + shipsDrownedByPlayerTwo} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneTotalShips - shipsDrownedByPlayerTwo} ships left. Player Two has {playerTwoTotalShips - shipsDrownedByPlayerOne} ships left.");
            }
        }
    }
}
