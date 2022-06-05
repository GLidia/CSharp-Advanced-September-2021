using System;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int beeRow = -1;
            int beeCol = -1;

            for (int row = 0; row < n; row++)
            {
                string rowInput = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowInput[col];
                    if (rowInput[col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }    
                }
            }

            string command;
            bool isOutside = false;
            int pollinatedFlowers = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "up")
                {
                    if (beeRow - 1 < 0)
                    {
                        matrix[beeRow, beeCol] = '.';
                        isOutside = true;
                        break;
                    }
                    else if (matrix[beeRow - 1, beeCol] == 'f')
                    {
                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow - 1, beeCol] = 'B';
                        beeRow--;
                        pollinatedFlowers++;
                    }
                    else if (matrix[beeRow - 1, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow - 1, beeCol] = '.';

                        if (beeRow - 2 < 0)
                        {
                            isOutside = true;
                            break;
                        }
                        else if (matrix[beeRow - 2, beeCol] == 'f')
                        {
                            matrix[beeRow - 2, beeCol] = 'B';
                            beeRow -= 2;
                            pollinatedFlowers++;
                        }
                        else if (matrix[beeRow - 2, beeCol] == '.')
                        {
                            matrix[beeRow - 2, beeCol] = 'B';
                            beeRow -= 2;
                        }
                    }
                    else if (matrix[beeRow - 1, beeCol] == '.')
                    {
                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow - 1, beeCol] = 'B';
                        beeRow--;
                    }
                }
                else if (command == "down")
                {
                    if (beeRow + 1 == n)
                    {
                        matrix[beeRow, beeCol] = '.';
                        isOutside = true;
                        break;
                    }
                    else if (matrix[beeRow + 1, beeCol] == 'f')
                    {
                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow + 1, beeCol] = 'B';
                        beeRow++;
                        pollinatedFlowers++;
                    }
                    else if (matrix[beeRow + 1, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow + 1, beeCol] = '.';

                        if (beeRow + 2 == n)
                        {
                            isOutside = true;
                            break;
                        }
                        else if (matrix[beeRow + 2, beeCol] == 'f')
                        {
                            matrix[beeRow + 2, beeCol] = 'B';
                            beeRow += 2;
                            pollinatedFlowers++;
                        }
                        else if (matrix[beeRow + 2, beeCol] == '.')
                        {
                            matrix[beeRow + 2, beeCol] = 'B';
                            beeRow += 2;
                        }
                    }
                    else if (matrix[beeRow + 1, beeCol] == '.')
                    {
                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow + 1, beeCol] = 'B';
                        beeRow++;
                    }
                }
                else if (command == "right")
                {
                    if (beeCol + 1 == n)
                    {
                        matrix[beeRow, beeCol] = '.';
                        isOutside = true;
                        break;
                    }
                    else if (matrix[beeRow, beeCol + 1] == 'f')
                    {
                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow, beeCol + 1] = 'B';
                        beeCol++;
                        pollinatedFlowers++;
                    }
                    else if (matrix[beeRow, beeCol + 1] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow, beeCol + 1] = '.';

                        if (beeCol + 2 == n)
                        {
                            isOutside = true;
                            break;
                        }
                        else if (matrix[beeRow, beeCol + 2] == 'f')
                        {
                            matrix[beeRow, beeCol + 2] = 'B';
                            beeCol += 2;
                            pollinatedFlowers++;
                        }
                        else if (matrix[beeRow, beeCol + 2] == '.')
                        {
                            matrix[beeRow, beeCol + 2] = 'B';
                            beeCol += 2;
                        }
                    }
                    else if (matrix[beeRow, beeCol + 1] == '.')
                    {
                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow, beeCol + 1] = 'B';
                        beeCol++;
                    }
                }
                else if (command == "left")
                {
                    if (beeCol - 1 < 0)
                    {
                        matrix[beeRow, beeCol] = '.';
                        isOutside = true;
                        break;
                    }
                    else if (matrix[beeRow, beeCol - 1] == 'f')
                    {
                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow, beeCol - 1] = 'B';
                        beeCol--;
                        pollinatedFlowers++;
                    }
                    else if (matrix[beeRow, beeCol - 1] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow, beeCol - 1] = '.';

                        if (beeCol - 2 < 0)
                        {
                            isOutside = true;
                            break;
                        }
                        else if (matrix[beeRow, beeCol - 2] == 'f')
                        {
                            matrix[beeRow, beeCol - 2] = 'B';
                            beeCol -= 2;
                            pollinatedFlowers++;
                        }
                        else if (matrix[beeRow, beeCol - 2] == '.')
                        {
                            matrix[beeRow, beeCol - 2] = 'B';
                            beeCol -= 2;
                        }
                    }
                    else if (matrix[beeRow, beeCol - 1] == '.')
                    {
                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow, beeCol - 1] = 'B';
                        beeCol--;
                    }

                }

            }

            if (isOutside)
            {
                Console.WriteLine("The bee got lost!");
            }

            if (pollinatedFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
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
