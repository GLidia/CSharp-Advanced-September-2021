using System;
using System.Linq;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];

            for (int row = 0; row < n; row++)
            {
                char[] rowInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                matrix[row] = rowInput;
            }

            int tokens = 0;
            int opponentTokens = 0;

            string input;
            while ((input = Console.ReadLine()) != "Gong")
            {
                string[] commandInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandInput[0];
                int row = int.Parse(commandInput[1]);
                int col = int.Parse(commandInput[2]);

                if (command == "Find")
                {
                    if (row >= 0 && row < n && col >= 0 && col < matrix[row].Length)
                    {
                        if (matrix[row][col] == 'T')
                        {
                            tokens++;
                            matrix[row][col] = '-';
                        }
                    }
                }
                else if (command == "Opponent")
                {
                    if (row >= 0 && row < n && col >= 0 && col < matrix[row].Length)
                    {
                        if (matrix[row][col] == 'T')
                        {
                            opponentTokens++;
                            matrix[row][col] = '-';
                        }

                        string direction = commandInput[3];

                        if (direction == "up")
                        {
                            for (int rowIndex = row; rowIndex >= row - 3; rowIndex--)
                            {
                                if (rowIndex >= 0 && rowIndex < n && col < matrix[rowIndex].Length)
                                {
                                    if (matrix[rowIndex][col] == 'T')
                                    {
                                        opponentTokens++;
                                        matrix[rowIndex][col] = '-';
                                    }
                                }
                            }
                        }
                        else if (direction == "down")
                        {
                            for (int rowIndex = row; rowIndex <= row + 3; rowIndex++)
                            {
                                if (rowIndex >= 0 && rowIndex < n && col < matrix[rowIndex].Length)
                                {
                                    if (matrix[rowIndex][col] == 'T')
                                    {
                                        opponentTokens++;
                                        matrix[rowIndex][col] = '-';
                                    }
                                }
                            }
                        }
                        else if (direction == "left")
                        {
                            if (col - 1 >= 0)
                            {
                                if (matrix[row][col - 1] == 'T')
                                {
                                    opponentTokens++;
                                    matrix[row][col - 1] = '-';
                                }
                            }

                            if (col - 2 >= 0)
                            {
                                if (matrix[row][col - 2] == 'T')
                                {
                                    opponentTokens++;
                                    matrix[row][col - 2] = '-';
                                }
                            }

                            if (col - 3 >= 0)
                            {
                                if (matrix[row][col - 3] == 'T')
                                {
                                    opponentTokens++;
                                    matrix[row][col - 3] = '-';
                                }
                            }
                        }
                        else if (direction == "right")
                        {

                            if (col + 1 < matrix[row].Length)
                            {
                                if (matrix[row][col + 1] == 'T')
                                {
                                    opponentTokens++;
                                    matrix[row][col + 1] = '-';
                                }
                            }

                            if (col + 2 < matrix[row].Length)
                            {
                                if (matrix[row][col + 2] == 'T')
                                {
                                    opponentTokens++;
                                    matrix[row][col + 2] = '-';
                                }
                            }

                            if (col + 3 < matrix[row].Length)
                            {
                                if (matrix[row][col + 3] == 'T')
                                {
                                    opponentTokens++;
                                    matrix[row][col + 3] = '-';
                                }
                            }


                        }
                    }
                }
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }

            Console.WriteLine($"Collected tokens: {tokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");

        }
    }
}
