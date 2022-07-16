using System;

namespace PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[8, 8];

            int wRow = -1;
            int wCol = -1;
            int bRow = -1;
            int bCol = -1;

            for (int row = 7; row >= 0; row--)
            {
                char[] rowInput = Console.ReadLine().ToCharArray();
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = rowInput[col];
                    if (matrix[row, col] == 'w')
                    {
                        wRow = row;
                        wCol = col;
                    }
                    else if (matrix[row, col] == 'b')
                    {
                        bRow = row;
                        bCol = col;
                    }
                }
            }

            bool wQueens = false;
            bool bQueens = false;
            bool wCaptures = false;
            bool bCaptures = false;

            while (true)
            {
                if (wRow + 1 == 7)
                {
                    wRow++;
                    wQueens = true;
                    break;
                }
                
                if (wCol - 1 >= 0)
                {
                    if (matrix[wRow + 1, wCol - 1] == 'b')
                    {
                        wRow++;
                        wCol--;
                        wCaptures = true;
                        break;
                    }
                }

                if (wCol + 1 <= 7)
                {
                    if (matrix[wRow + 1, wCol + 1] == 'b')
                    {
                        wRow++;
                        wCol++;
                        wCaptures = true;
                        break;
                    }
                }

                matrix[wRow, wCol] = '-';
                matrix[wRow + 1, wCol] = 'w';
                wRow++;

                if (bRow - 1 == 0)
                {
                    bRow--;
                    bQueens = true;
                    break;
                }

                if (bCol - 1 >= 0)
                {
                    if (matrix[bRow - 1, bCol - 1] == 'w')
                    {
                        bRow--;
                        bCol--;
                        bCaptures = true;
                        break;
                    }
                }

                if (bCol + 1 <= 7)
                {
                    if (matrix[bRow - 1, bCol + 1] == 'w')
                    {
                        bRow--;
                        bCol++;
                        bCaptures = true;
                        break;
                    }
                }

                matrix[bRow, bCol] = '-';
                matrix[bRow - 1, bCol] = 'b';
                bRow--;
            }

            wRow++;
            bRow++;
            char blackCol = (char)(bCol + 97);
            char whiteCol = (char)(wCol + 97);

            if (wQueens)
            {
                Console.WriteLine($"Game over! White pawn is promoted to a queen at {whiteCol}{wRow}.");
            }
            else if (bQueens)
            {
                Console.WriteLine($"Game over! Black pawn is promoted to a queen at {blackCol}{bRow}.");
            }
            else if (wCaptures)
            {
                Console.WriteLine($"Game over! White capture on {whiteCol}{wRow}.");
            }
            else if (bCaptures)
            {
                Console.WriteLine($"Game over! Black capture on {blackCol}{bRow}.");
            }
        }
    }
}
