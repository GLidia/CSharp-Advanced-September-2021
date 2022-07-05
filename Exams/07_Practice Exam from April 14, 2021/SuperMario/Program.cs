using System;
using System.Linq;

namespace SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            // 90/100
            int lives = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];

            int marioRow = -1;
            int marioCol = -1;
            int colCount = -1;

            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                char[] rowInput = input.ToCharArray().Where(x => x != ' ').ToArray();
                matrix[row] = new char[rowInput.Length];
                colCount = rowInput.Length;

                for (int col = 0; col < rowInput.Length; col++)
                {

                    matrix[row][col] = rowInput[col];
                    if (rowInput[col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                }
            }

            bool isDead = false;
            bool hasWon = false;

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string direction = input[0];
                int bowserRow = int.Parse(input[1]);
                int bowserCol = int.Parse(input[2]);

                matrix[bowserRow][bowserCol] = 'B';

                if (direction == "W")
                {

                    if (marioRow - 1 < 0)
                    {
                        lives--;
                    }
                    else
                    {
                        lives--;
                        if (matrix[marioRow - 1][marioCol] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                isDead = true;
                                matrix[marioRow - 1][marioCol] = 'X';
                                matrix[marioRow][marioCol] = '-';
                                marioRow--;
                                break;
                            }
                            else if (lives > 0)
                            {
                                matrix[marioRow - 1][marioCol] = 'M';
                                matrix[marioRow][marioCol] = '-';
                                marioRow--;
                            }
                        }
                        else if (matrix[marioRow - 1][marioCol] == '-')
                        {
                            matrix[marioRow - 1][marioCol] = 'M';
                            matrix[marioRow][marioCol] = '-';
                            marioRow--;
                        }
                        else if (matrix[marioRow - 1][marioCol] == 'P')
                        {
                            hasWon = true;
                            matrix[marioRow - 1][marioCol] = '-';
                            matrix[marioRow][marioCol] = '-';
                            break;
                        }
                    }
                }
                else if (direction == "S")
                {

                    if (marioRow + 1 >= rows)
                    {
                        lives--;
                    }
                    else
                    {
                        lives--;
                        if (matrix[marioRow + 1][marioCol] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                isDead = true;
                                matrix[marioRow + 1][marioCol] = 'X';
                                matrix[marioRow][marioCol] = '-';
                                marioRow++;
                                break;
                            }
                            else if (lives > 0)
                            {
                                matrix[marioRow + 1][marioCol] = 'M';
                                matrix[marioRow][marioCol] = '-';
                                marioRow++;
                            }
                        }
                        else if (matrix[marioRow + 1][marioCol] == '-')
                        {
                            matrix[marioRow - 1][marioCol] = 'M';
                            matrix[marioRow][marioCol] = '-';
                            marioRow++;
                        }
                        else if (matrix[marioRow + 1][marioCol] == 'P')
                        {
                            hasWon = true;
                            matrix[marioRow][marioCol] = '-';
                            matrix[marioRow + 1][marioCol] = '-';
                            break;
                        }
                    }
                }
                else if (direction == "A")
                {

                    if (marioCol - 1 < 0)
                    {
                        lives--;
                    }
                    else
                    {
                        lives--;
                        if (matrix[marioRow][marioCol - 1] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                isDead = true;
                                matrix[marioRow][marioCol - 1] = 'X';
                                matrix[marioRow][marioCol] = '-';
                                marioCol--;
                                break;
                            }
                            else if (lives > 0)
                            {
                                matrix[marioRow][marioCol - 1] = 'M';
                                matrix[marioRow][marioCol] = '-';
                                marioCol--;
                            }
                        }
                        else if (matrix[marioRow][marioCol - 1] == '-')
                        {
                            matrix[marioRow][marioCol - 1] = 'M';
                            matrix[marioRow][marioCol] = '-';
                            marioCol--;
                        }
                        else if (matrix[marioRow][marioCol - 1] == 'P')
                        {
                            hasWon = true;
                            matrix[marioRow][marioCol - 1] = '-';
                            matrix[marioRow][marioCol] = '-';
                            break;
                        }
                    }
                }
                else if (direction == "D")
                {

                    if (marioCol + 1 >= colCount)
                    {
                        lives--;
                    }
                    else
                    {
                        lives--;
                        if (matrix[marioRow][marioCol + 1] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                isDead = true;
                                matrix[marioRow][marioCol + 1] = 'X';
                                matrix[marioRow][marioCol] = '-';
                                marioCol++;
                                break;
                            }
                            else if (lives > 0)
                            {
                                matrix[marioRow][marioCol + 1] = 'M';
                                matrix[marioRow][marioCol] = '-';
                                marioCol++;
                            }
                        }
                        else if (matrix[marioRow][marioCol + 1] == '-')
                        {
                            matrix[marioRow][marioCol + 1] = 'M';
                            matrix[marioRow][marioCol] = '-';
                            marioCol++;
                        }
                        else if (matrix[marioRow][marioCol + 1] == 'P')
                        {
                            hasWon = true;
                            matrix[marioRow][marioCol + 1] = '-';
                            matrix[marioRow][marioCol] = '-';
                            break;
                        }
                    }
                }

                if (lives <= 0)
                {
                    isDead = true;
                    matrix[marioRow][marioCol] = 'X';
                    break;
                }
            }

            if (isDead)
            {
                Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
            }
            else if (hasWon)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join("", matrix[row]));
            }
        }
    }
}
