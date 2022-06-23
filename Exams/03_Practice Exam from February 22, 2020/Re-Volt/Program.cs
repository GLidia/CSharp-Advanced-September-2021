using System;
using System.Linq;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < n; row++)
            {
                string rowInput = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowInput[col];
                    if (rowInput[col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            int newPlayerRow = playerRow;
            int newPlayerCol = playerCol;
            bool hasWon = false;

            for (int i = 0; i < commandsCount; i++)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    if (playerRow - 1 < 0)
                    {
                        newPlayerRow = n - 1;
                    }
                    else
                    {
                        newPlayerRow = playerRow - 1;
                    }

                    if (matrix[newPlayerRow, playerCol] == '-')
                    {
                        matrix[playerRow, playerCol] = '-';
                        matrix[newPlayerRow, playerCol] = 'f';
                        playerRow = newPlayerRow;
                    }
                    else if (matrix[newPlayerRow, playerCol] == 'B')
                    {
                        if (newPlayerRow - 1 < 0)
                        {
                            newPlayerRow = n - 1;
                        }
                        else
                        {
                            newPlayerRow--;
                        }

                        if (matrix[newPlayerRow, playerCol] == '-')
                        {
                            matrix[playerRow, playerCol] = '-';
                            matrix[newPlayerRow, playerCol] = 'f';
                            playerRow = newPlayerRow;
                        }
                        else if (matrix[newPlayerRow, playerCol] == 'F')
                        {
                            hasWon = true;
                            matrix[newPlayerRow, playerCol] = 'f';
                            matrix[playerRow, playerCol] = '-';
                            playerRow = newPlayerRow;
                            break;
                        }
                    }
                    else if (matrix[newPlayerRow, playerCol] == 'F')
                    {
                        hasWon = true;
                        matrix[newPlayerRow, playerCol] = 'f';
                        matrix[playerRow, playerCol] = '-';
                        playerRow = newPlayerRow;
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (playerRow + 1 == n)
                    {
                        newPlayerRow = 0;
                    }
                    else
                    {
                        newPlayerRow = playerRow + 1;
                    }

                    if (matrix[newPlayerRow, playerCol] == '-')
                    {
                        matrix[playerRow, playerCol] = '-';
                        matrix[newPlayerRow, playerCol] = 'f';
                        playerRow = newPlayerRow;
                    }
                    else if (matrix[newPlayerRow, playerCol] == 'B')
                    {
                        if (newPlayerRow + 1 == n)
                        {
                            newPlayerRow = 0;
                        }
                        else
                        {
                            newPlayerRow++;
                        }

                        if (matrix[newPlayerRow, playerCol] == '-')
                        {
                            matrix[playerRow, playerCol] = '-';
                            matrix[newPlayerRow, playerCol] = 'f';
                            playerRow = newPlayerRow;
                        }
                        else if (matrix[newPlayerRow, playerCol] == 'F')
                        {
                            hasWon = true;
                            matrix[newPlayerRow, playerCol] = 'f';
                            matrix[playerRow, playerCol] = '-';
                            playerRow = newPlayerRow;
                            break;
                        }
                    }
                    else if (matrix[newPlayerRow, playerCol] == 'F')
                    {
                        hasWon = true;
                        matrix[newPlayerRow, playerCol] = 'f';
                        matrix[playerRow, playerCol] = '-';
                        playerRow = newPlayerRow;
                        break;
                    }
                }
                else if (command == "left")
                {
                    if (playerCol - 1 < 0)
                    {
                        newPlayerCol = n - 1;
                    }
                    else
                    {
                        newPlayerCol = playerCol - 1;
                    }

                    if (matrix[playerRow, newPlayerCol] == '-')
                    {
                        matrix[playerRow, playerCol] = '-';
                        matrix[playerRow, newPlayerCol] = 'f';
                        playerCol = newPlayerCol;
                    }
                    else if (matrix[playerRow, newPlayerCol] == 'B')
                    {
                        if (newPlayerCol - 1 < 0)
                        {
                            newPlayerCol = n - 1;
                        }
                        else
                        {
                            newPlayerCol--;
                        }

                        if (matrix[playerRow, newPlayerCol] == '-')
                        {
                            matrix[playerRow, playerCol] = '-';
                            matrix[playerRow, newPlayerCol] = 'f';
                            playerCol = newPlayerCol;
                        }
                        else if (matrix[playerRow, newPlayerCol] == 'F')
                        {
                            hasWon = true;
                            matrix[playerRow, newPlayerCol] = 'f';
                            matrix[playerRow, playerCol] = '-';
                            playerCol = newPlayerCol;
                            break;
                        }
                    }
                    else if (matrix[playerRow, newPlayerCol] == 'F')
                    {
                        hasWon = true;
                        matrix[playerRow, newPlayerCol] = 'f';
                        matrix[playerRow, playerCol] = '-';
                        playerCol = newPlayerCol;
                        break;
                    }
                }
                else if (command == "right")
                {
                    if (playerCol + 1 == n)
                    {
                        newPlayerCol = 0;
                    }
                    else
                    {
                        newPlayerCol = playerCol + 1;
                    }

                    if (matrix[playerRow, newPlayerCol] == '-')
                    {
                        matrix[playerRow, playerCol] = '-';
                        matrix[playerRow, newPlayerCol] = 'f';
                        playerCol = newPlayerCol;
                    }
                    else if (matrix[playerRow, newPlayerCol] == 'B')
                    {
                        if (newPlayerCol + 1 == n)
                        {
                            newPlayerCol = 0;
                        }
                        else
                        {
                            newPlayerCol++;
                        }

                        if (matrix[playerRow, newPlayerCol] == '-')
                        {
                            matrix[playerRow, playerCol] = '-';
                            matrix[playerRow, newPlayerCol] = 'f';
                            playerCol = newPlayerCol;
                        }
                        else if (matrix[playerRow, newPlayerCol] == 'F')
                        {
                            hasWon = true;
                            matrix[playerRow, newPlayerCol] = 'f';
                            matrix[playerRow, playerCol] = '-';
                            playerCol = newPlayerCol;
                            break;
                        }
                    }
                    else if (matrix[playerRow, newPlayerCol] == 'F')
                    {
                        hasWon = true;
                        matrix[playerRow, newPlayerCol] = 'f';
                        matrix[playerRow, playerCol] = '-';
                        playerCol = newPlayerCol;
                        break;
                    }
                }
            }

            if (hasWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
