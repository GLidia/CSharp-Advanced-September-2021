using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = matrixSizes[0];
            int M = matrixSizes[1];
            char[,] lair = new char[matrixSizes[0], matrixSizes[1]];
            int currentRow = -1;
            int currentCol = -1;

            for (int row = 0; row < matrixSizes[0]; row++)
            {
                char[] rowInput = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrixSizes[1]; col++)
                {
                    lair[row, col] = rowInput[col];

                    if (rowInput[col] == 'P')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }

            }

            bool dead = false;
            bool won = false;
            char[] commands = Console.ReadLine().ToCharArray();

            for (int i = 0; i < commands.Length; i++)
            {
                char command = commands[i];

                // player moving
                if (command == 'L')
                {
                    if (currentCol - 1 < 0)
                    {
                        won = true;
                        lair[currentRow, currentCol] = '.';
                    }
                    else if (lair[currentRow, currentCol - 1] == 'B')
                    {
                        dead = true;
                        lair[currentRow, currentCol] = '.';
                        currentCol--;
                    }
                    else
                    {
                        lair[currentRow, currentCol] = '.';
                        lair[currentRow, currentCol - 1] = 'P';
                        currentCol -= 1;
                    }
                }
                else if (command == 'R')
                {
                    if (currentCol + 1 >= matrixSizes[1])
                    {
                        won = true;
                        lair[currentRow, currentCol] = '.';
                    }
                    else if (lair[currentRow, currentCol + 1] == 'B')
                    {
                        dead = true;
                        lair[currentRow, currentCol] = '.';
                        currentCol++;
                    }
                    else
                    {
                        lair[currentRow, currentCol] = '.';
                        lair[currentRow, currentCol + 1] = 'P';
                        currentCol += 1;
                    }
                }
                else if (command == 'U')
                {
                    if (currentRow - 1 < 0)
                    {
                        won = true;
                        lair[currentRow, currentCol] = '.';
                    }
                    else if (lair[currentRow - 1, currentCol] == 'B')
                    {
                        dead = true;
                        lair[currentRow, currentCol] = '.';
                        currentRow--;
                    }
                    else
                    {
                        lair[currentRow, currentCol] = '.';
                        lair[currentRow - 1, currentCol] = 'P';
                        currentRow--;
                    }
                }
                else if (command == 'D')
                {
                    if (currentRow + 1 >= matrixSizes[0])
                    {
                        won = true;
                        lair[currentRow, currentCol] = '.';
                    }
                    else if (lair[currentRow + 1, currentCol] == 'B')
                    {
                        dead = true;
                        lair[currentRow, currentCol] = '.';
                        currentRow++;
                    }
                    else
                    {
                        lair[currentRow, currentCol] = '.';
                        lair[currentRow + 1, currentCol] = 'P';
                        currentRow++;
                    }
                }

                char[,] newLair = new char[matrixSizes[0], matrixSizes[1]];

                for (int row = 0; row < matrixSizes[0]; row++)
                {
                    for (int col = 0; col < matrixSizes[1]; col++)
                    {
                        newLair[row, col] = lair[row, col];
                    }
                }


                //bunnies multiplying
                for (int row = 0; row < matrixSizes[0]; row++)
                {
                    for (int col = 0; col < matrixSizes[1]; col++)
                    {
                     
                        if (lair[row, col] == 'B')
                        {
                            newLair[row, col] = 'B';
                            if (row - 1 >= 0)
                            {
                               if (lair[row - 1, col] == 'P')
                               {
                                   dead = true;
                               }
                                newLair[row - 1, col] = 'B';
                            }
                            
                            if (row + 1 < lair.GetLength(0))
                            {
                                if (lair[row + 1, col] == 'P')
                                {
                                    dead = true;
                                }
                                newLair[row + 1, col] = 'B';
                            }

                            if (col - 1 >= 0)
                            {
                                if (lair[row, col - 1] == 'P')
                               {
                                    dead = true;
                                }
                                newLair[row, col - 1] = 'B';
                            }

                            if (col + 1 < lair.GetLength(1))
                            {
                                if (lair[row, col + 1] == 'P')
                                {
                                    dead = true;
                                }
                                newLair[row, col + 1] = 'B';
                            }

                        }
                    }

                }

                lair = newLair;

                if (dead || won)
                {
                    break;
                }

            }

            for (int row = 0; row < matrixSizes[0]; row++)
            {
                for (int col = 0; col < matrixSizes[1]; col++)
                {
                    Console.Write(lair[row, col]);
                }
                Console.WriteLine();
            }

            if (dead)
            {
                Console.WriteLine($"dead: {currentRow} {currentCol}");
            }
            else if (won)
            {
                Console.WriteLine($"won: {currentRow} {currentCol}");
            }

        }
    }
}
