using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int snakeRow = 0;
            int snakeCol = 0;

            bool foundFirstBurrow = false;

            int firstBurrowRow = -1;
            int firstBurrowCol = -1;
            int secBurrowRow = -1;
            int secBurrowCol = -1;

            for (int row = 0; row < n; row++)
            {
                string rowInput = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowInput[col];
                    if (rowInput[col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                    else if(rowInput[col] == 'B')
                    {
                        if (!foundFirstBurrow)
                        {
                            firstBurrowRow = row;
                            firstBurrowCol = col;
                            foundFirstBurrow = true;
                        }
                        else
                        {
                            secBurrowRow = row;
                            secBurrowCol = col;
                        }
                    }
                }
            }

            int foodEaten = 0;
            bool isOutside = false;
            bool enoughFoodEaten = false;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "down")
                {
                    matrix[snakeRow, snakeCol] = '.';
                    if (snakeRow + 1 == n)
                    {
                        isOutside = true;
                        break;
                    }

                    if (matrix[snakeRow + 1, snakeCol] == '-')
                    {
                        matrix[snakeRow + 1, snakeCol] = 'S';
                        snakeRow++;
                    }
                    else if (matrix[snakeRow + 1, snakeCol] == '*')
                    {
                        foodEaten++;
                        matrix[snakeRow + 1, snakeCol] = 'S';
                        snakeRow++;
                        if (foodEaten >= 10)
                        {
                            enoughFoodEaten = true;
                            break;
                        }
                    }
                    else if (matrix[snakeRow + 1, snakeCol] == 'B')
                    {
                        matrix[snakeRow + 1, snakeCol] = '.';
                        if (snakeRow + 1 == firstBurrowRow && snakeCol == firstBurrowCol)
                        {
                            matrix[secBurrowRow, secBurrowCol] = 'S';
                            snakeRow = secBurrowRow;
                            snakeCol = secBurrowCol;
                        }
                        else
                        {
                            matrix[firstBurrowRow, firstBurrowCol] = 'S';
                            snakeRow = firstBurrowRow;
                            snakeCol = firstBurrowCol;
                        }
                    }
                }
                else if (command == "up")
                {
                    matrix[snakeRow, snakeCol] = '.';
                    if (snakeRow - 1 == -1)
                    {
                        isOutside = true;
                        break;
                    }

                    if (matrix[snakeRow - 1, snakeCol] == '-')
                    {
                        matrix[snakeRow - 1, snakeCol] = 'S';
                        snakeRow--;
                    }
                    else if (matrix[snakeRow - 1, snakeCol] == '*')
                    {
                        foodEaten++;
                        matrix[snakeRow - 1, snakeCol] = 'S';
                        snakeRow--;
                        if (foodEaten >= 10)
                        {
                            enoughFoodEaten = true;
                            break;
                        }
                    }
                    else if (matrix[snakeRow - 1, snakeCol] == 'B')
                    {
                        matrix[snakeRow - 1, snakeCol] = '.';
                        if (snakeRow - 1 == firstBurrowRow && snakeCol == firstBurrowCol)
                        {
                            matrix[secBurrowRow, secBurrowCol] = 'S';
                            snakeRow = secBurrowRow;
                            snakeCol = secBurrowCol;
                        }
                        else
                        {
                            matrix[firstBurrowRow, firstBurrowCol] = 'S';
                            snakeRow = firstBurrowRow;
                            snakeCol = firstBurrowCol;
                        }
                    }
                }
                else if (command == "left")
                {
                    matrix[snakeRow, snakeCol] = '.';
                    if (snakeCol - 1 == -1)
                    {
                        isOutside = true;
                        break;
                    }

                    if (matrix[snakeRow, snakeCol - 1] == '-')
                    {
                        matrix[snakeRow, snakeCol - 1] = 'S';
                        snakeCol--;
                    }
                    else if (matrix[snakeRow, snakeCol - 1] == '*')
                    {
                        foodEaten++;
                        matrix[snakeRow, snakeCol - 1] = 'S';
                        snakeCol--;
                        if (foodEaten >= 10)
                        {
                            enoughFoodEaten = true;
                            break;
                        }
                    }
                    else if (matrix[snakeRow, snakeCol - 1] == 'B')
                    {
                        matrix[snakeRow, snakeCol - 1] = '.';
                        if (snakeRow == firstBurrowRow && snakeCol - 1 == firstBurrowCol)
                        {
                            matrix[secBurrowRow, secBurrowCol] = 'S';
                            snakeRow = secBurrowRow;
                            snakeCol = secBurrowCol;
                        }
                        else
                        {
                            matrix[firstBurrowRow, firstBurrowCol] = 'S';
                            snakeRow = firstBurrowRow;
                            snakeCol = firstBurrowCol;
                        }
                    }
                }
                else if (command == "right")
                {
                    matrix[snakeRow, snakeCol] = '.';
                    if (snakeCol + 1 == n)
                    {
                        isOutside = true;
                        break;
                    }

                    if (matrix[snakeRow, snakeCol + 1] == '-')
                    {
                        matrix[snakeRow, snakeCol + 1] = 'S';
                        snakeCol++;
                    }
                    else if (matrix[snakeRow, snakeCol + 1] == '*')
                    {
                        foodEaten++;
                        matrix[snakeRow, snakeCol + 1] = 'S';
                        snakeCol++;
                        if (foodEaten >= 10)
                        {
                            enoughFoodEaten = true;
                            break;
                        }
                    }
                    else if (matrix[snakeRow, snakeCol + 1] == 'B')
                    {
                        matrix[snakeRow, snakeCol + 1] = '.';
                        if (snakeRow == firstBurrowRow && snakeCol + 1 == firstBurrowCol)
                        {
                            matrix[secBurrowRow, secBurrowCol] = 'S';
                            snakeRow = secBurrowRow;
                            snakeCol = secBurrowCol;
                        }
                        else
                        {
                            matrix[firstBurrowRow, firstBurrowCol] = 'S';
                            snakeRow = firstBurrowRow;
                            snakeCol = firstBurrowCol;
                        }
                    }
                }


                //for (int row = 0; row < n; row++)
                //{
                //    for (int col = 0; col < n; col++)
                //    {
                //        Console.Write(matrix[row, col]);
                //    }
                //    Console.WriteLine();
                //}

            }

            if (isOutside)
            {
                Console.WriteLine("Game over!");
            }
            else
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodEaten}");

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
