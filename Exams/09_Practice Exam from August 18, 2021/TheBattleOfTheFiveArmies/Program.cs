using System;

namespace TheBattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];

            int armyRow = -1;
            int armyCol = -1;

            for (int row = 0; row < n; row++)
            {
                string rowInput = Console.ReadLine();
                matrix[row] = new char[rowInput.Length];
                for (int col = 0; col < rowInput.Length; col++)
                {
                    matrix[row][col] = rowInput[col];
                    if (rowInput[col] == 'A')
                    {
                        armyRow = row;
                        armyCol = col;
                    }
                }
            }

            int newArmyRow = armyRow;
            int newArmyCol = armyCol;
            bool hasWon = false;
            bool isDead = false;

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                int orcRow = int.Parse(input[1]);
                int orcCol = int.Parse(input[2]);

                matrix[orcRow][orcCol] = 'O';

                armor--;
                if (command == "up")
                {
                    if (armyRow - 1 < 0)
                    {
                        continue;
                    }
                    else
                    {
                        newArmyRow = armyRow - 1;
                    }

                    if (matrix[newArmyRow][armyCol] == '-')
                    {
                        matrix[armyRow][armyCol] = '-';
                        matrix[newArmyRow][armyCol] = 'A';
                        armyRow--;
                    }
                    else if (matrix[newArmyRow][armyCol] == 'O')
                    {
                        armor -= 2;
                        matrix[armyRow][armyCol] = '-';
                        matrix[newArmyRow][armyCol] = 'A';
                        armyRow--;
                    }
                    else if (matrix[newArmyRow][armyCol] == 'M')
                    {
                        matrix[armyRow][armyCol] = '-';
                        matrix[newArmyRow][armyCol] = '-';
                        hasWon = true;
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (armyRow + 1 >= n)
                    {
                        continue;
                    }
                    else
                    {
                        newArmyRow = armyRow + 1;
                    }

                    if (matrix[newArmyRow][armyCol] == '-')
                    {
                        matrix[armyRow][armyCol] = '-';
                        matrix[newArmyRow][armyCol] = 'A';
                        armyRow++;
                    }
                    else if (matrix[newArmyRow][armyCol] == 'O')
                    {
                        armor -= 2;
                        matrix[armyRow][armyCol] = '-';
                        matrix[newArmyRow][armyCol] = 'A';
                        armyRow++;
                    }
                    else if (matrix[newArmyRow][armyCol] == 'M')
                    {
                        matrix[armyRow][armyCol] = '-';
                        matrix[newArmyRow][armyCol] = '-';
                        hasWon = true;
                        break;
                    }
                }
                if (command == "left")
                {
                    if (armyCol - 1 < 0)
                    {
                        continue;
                    }
                    else
                    {
                        newArmyCol = armyCol - 1;
                    }

                    if (matrix[armyRow][newArmyCol] == '-')
                    {
                        matrix[armyRow][armyCol] = '-';
                        matrix[armyRow][newArmyCol] = 'A';
                        armyCol--;
                    }
                    else if (matrix[armyRow][newArmyCol] == 'O')
                    {
                        armor -= 2;
                        matrix[armyRow][armyCol] = '-';
                        matrix[armyRow][newArmyCol] = 'A';
                        armyCol--;
                    }
                    else if (matrix[armyRow][newArmyCol] == 'M')
                    {
                        matrix[armyRow][armyCol] = '-';
                        matrix[armyRow][newArmyCol] = '-';
                        hasWon = true;
                        break;
                    }
                }
                if (command == "right")
                {
                    if (armyCol + 1 >= n)
                    {
                        continue;
                    }
                    else
                    {
                        newArmyCol = armyCol + 1;
                    }

                    if (matrix[armyRow][newArmyCol] == '-')
                    {
                        matrix[armyRow][armyCol] = '-';
                        matrix[armyRow][newArmyCol] = 'A';
                        armyCol++;
                    }
                    else if (matrix[armyRow][newArmyCol] == 'O')
                    {
                        armor -= 2;
                        matrix[armyRow][armyCol] = '-';
                        matrix[armyRow][newArmyCol] = 'A';
                        armyCol++;
                    }
                    else if (matrix[armyRow][newArmyCol] == 'M')
                    {
                        matrix[armyRow][armyCol] = '-';
                        matrix[armyRow][newArmyCol] = '-';
                        hasWon = true;
                        break;
                    }
                }

                if (armor <= 0)
                {
                    matrix[armyRow][armyCol] = 'X';
                    isDead = true;
                    break;
                }
            }

            if (hasWon)
            {
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
            }
            else if (isDead)
            {
                Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
            }

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join("", matrix[row]));
            }
        }
    }
}
