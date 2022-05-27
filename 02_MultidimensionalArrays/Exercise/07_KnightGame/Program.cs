using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char[,] matrix = new char[N, N];
            int countOfRemovedKnights = 0;

            for (int row = 0; row < N; row++)
            {
                char[] rowInput = Console.ReadLine().ToCharArray();

                for (int col = 0; col < N; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            while (true)
            {
                // index of knigth + List of row, col, and number of knights it attacks
                Dictionary<int, List<int>> knights = new Dictionary<int, List<int>>();
                int count = 0;

                for (int row = 0; row < N; row++)
                {
                    for (int col = 0; col < N; col++)
                    {
                        int currentKnight = count;

                        if (matrix[row, col] == 'K')
                        {
                            List<int> coordinatesAndHits = new List<int>();
                            coordinatesAndHits.Add(row);
                            coordinatesAndHits.Add(col);
                            coordinatesAndHits.Add(0);
                            knights.Add(currentKnight, coordinatesAndHits);
                            count++;
                        }
                        else
                        {
                            continue;
                        }

                        if (row + 1 < N && col + 2 < N && matrix[row + 1, col + 2] == 'K')
                        {
                            knights[currentKnight][2]++;
                        }

                        if (row + 2 < N && col + 1 < N && matrix[row + 2, col + 1] == 'K')
                        {
                            knights[currentKnight][2]++;
                        }

                        if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1, col - 2] == 'K')
                        {
                            knights[currentKnight][2]++;
                        }

                        if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2, col - 1] == 'K')
                        {
                            knights[currentKnight][2]++;
                        }

                        if (row - 1 >= 0 && col + 2 < N && matrix[row - 1, col + 2] == 'K')
                        {
                            knights[currentKnight][2]++;
                        }

                        if (row - 2 >= 0 && col + 1 < N && matrix[row - 2, col + 1] == 'K')
                        {
                            knights[currentKnight][2]++;
                        }

                        if (row + 1 < N && col - 2 >= 0 && matrix[row + 1, col - 2] == 'K')
                        {
                            knights[currentKnight][2]++;
                        }

                        if (row + 2 < N && col - 1 >= 0 && matrix[row + 2, col - 1] == 'K')
                        {
                            knights[currentKnight][2]++;
                        }
                    }
                }

                int maxAttacked = 0;
                int indexOfMostAttackingKnight = -1;

                foreach (var knight in knights)
                {
                    if (knight.Value[2] > maxAttacked)
                    {
                        maxAttacked = knight.Value[2];
                        indexOfMostAttackingKnight = knight.Key;

                    }
                }

                if (indexOfMostAttackingKnight != -1)
                {
                    int rowOfAttKnight = knights[indexOfMostAttackingKnight][0];
                    int colOfAttKnight = knights[indexOfMostAttackingKnight][1];
                    matrix[rowOfAttKnight, colOfAttKnight] = '0';
                    countOfRemovedKnights++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(countOfRemovedKnights);
        }
    }
}
