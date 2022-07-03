using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] bakery = new char[n, n];

            int sellerRow = -1;
            int sellerCol = -1;
            bool firstPillarFound = false;
            int pillarOneRow = -1;
            int pillarOneCol = -1;
            int pillarTwoRow = -1;
            int pillarTwoCol = -1;

            for (int row = 0; row < n; row++)
            {
                string rowInput = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    bakery[row, col] = rowInput[col];
                    if (rowInput[col] == 'S')
                    {
                        sellerRow = row;
                        sellerCol = col;
                    }

                    if (rowInput[col] == 'O')
                    {
                        if (!firstPillarFound)
                        {
                            firstPillarFound = true;
                            pillarOneRow = row;
                            pillarOneCol = col;
                        }
                        else
                        {
                            pillarTwoRow = row;
                            pillarTwoCol = col;
                        }
                    }
                }
            }

            int collectedMoney = 0;
            bool isOutside = false;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    if (sellerRow - 1 < 0)
                    {
                        bakery[sellerRow, sellerCol] = '-';
                        isOutside = true;
                        break;
                    }

                    if(char.IsDigit(bakery[sellerRow - 1, sellerCol]))
                    {
                        collectedMoney += bakery[sellerRow - 1, sellerCol] - '0';
                        bakery[sellerRow, sellerCol] = '-';
                        bakery[sellerRow - 1, sellerCol] = 'S';
                        sellerRow--;
                        if (collectedMoney >= 50)
                        {
                            break;
                        }
                    }
                    else if (bakery[sellerRow - 1, sellerCol] == 'O')
                    {
                        if(sellerRow - 1 == pillarOneRow && sellerCol == pillarOneCol)
                        {
                            bakery[sellerRow, sellerCol] = '-';
                            bakery[sellerRow - 1, sellerCol] = '-';
                            bakery[pillarTwoRow, pillarTwoCol] = 'S';
                            sellerRow = pillarTwoRow;
                            sellerCol = pillarTwoCol;
                        }
                        else
                        {
                            bakery[sellerRow, sellerCol] = '-';
                            bakery[sellerRow - 1, sellerCol] = '-';
                            bakery[pillarOneRow, pillarOneCol] = 'S';
                            sellerRow = pillarOneRow;
                            sellerCol = pillarOneCol;
                        }
                    }
                    else if (bakery[sellerRow - 1, sellerCol] == '-')
                    {
                        bakery[sellerRow, sellerCol] = '-';
                        bakery[sellerRow - 1, sellerCol] = 'S';
                        sellerRow--;
                    }
                }
                else if (command == "down")
                {
                    if (sellerRow + 1 == n)
                    {
                        bakery[sellerRow, sellerCol] = '-';
                        isOutside = true;
                        break;
                    }

                    if (char.IsDigit(bakery[sellerRow + 1, sellerCol]))
                    {
                        collectedMoney += bakery[sellerRow + 1, sellerCol] - '0';
                        bakery[sellerRow, sellerCol] = '-';
                        bakery[sellerRow + 1, sellerCol] = 'S';
                        sellerRow++;
                        if (collectedMoney >= 50)
                        {
                            break;
                        }
                    }
                    else if (bakery[sellerRow + 1, sellerCol] == 'O')
                    {
                        if (sellerRow + 1 == pillarOneRow && sellerCol == pillarOneCol)
                        {
                            bakery[sellerRow, sellerCol] = '-';
                            bakery[sellerRow + 1, sellerCol] = '-';
                            bakery[pillarTwoRow, pillarTwoCol] = 'S';
                            sellerRow = pillarTwoRow;
                            sellerCol = pillarTwoCol;
                        }
                        else
                        {
                            bakery[sellerRow, sellerCol] = '-';
                            bakery[sellerRow + 1, sellerCol] = '-';
                            bakery[pillarOneRow, pillarOneCol] = 'S';
                            sellerRow = pillarOneRow;
                            sellerCol = pillarOneCol;
                        }
                    }
                    else if (bakery[sellerRow + 1, sellerCol] == '-')
                    {
                        bakery[sellerRow, sellerCol] = '-';
                        bakery[sellerRow + 1, sellerCol] = 'S';
                        sellerRow++;
                    }
                }
                else if (command == "left")
                {
                    if (sellerCol - 1 < 0)
                    {
                        bakery[sellerRow, sellerCol] = '-';
                        isOutside = true;
                        break;
                    }

                    if (char.IsDigit(bakery[sellerRow, sellerCol - 1]))
                    {
                        collectedMoney += bakery[sellerRow, sellerCol - 1] - '0';
                        bakery[sellerRow, sellerCol] = '-';
                        bakery[sellerRow, sellerCol - 1] = 'S';
                        sellerCol--;
                        if (collectedMoney >= 50)
                        {
                            break;
                        }
                    }
                    else if (bakery[sellerRow, sellerCol - 1] == 'O')
                    {
                        if (sellerRow == pillarOneRow && sellerCol - 1 == pillarOneCol)
                        {
                            bakery[sellerRow, sellerCol] = '-';
                            bakery[sellerRow, sellerCol - 1] = '-';
                            bakery[pillarTwoRow, pillarTwoCol] = 'S';
                            sellerRow = pillarTwoRow;
                            sellerCol = pillarTwoCol;
                        }
                        else
                        {
                            bakery[sellerRow, sellerCol] = '-';
                            bakery[sellerRow, sellerCol - 1] = '-';
                            bakery[pillarOneRow, pillarOneCol] = 'S';
                            sellerRow = pillarOneRow;
                            sellerCol = pillarOneCol;
                        }
                    }
                    else if (bakery[sellerRow, sellerCol - 1] == '-')
                    {
                        bakery[sellerRow, sellerCol] = '-';
                        bakery[sellerRow, sellerCol - 1] = 'S';
                        sellerCol--;
                    }
                }
                else if (command == "right")
                {
                    if (sellerCol + 1 == n)
                    {
                        bakery[sellerRow, sellerCol] = '-';
                        isOutside = true;
                        break;
                    }

                    if (char.IsDigit((bakery[sellerRow, sellerCol + 1])))
                    {
                        collectedMoney += (int)(bakery[sellerRow, sellerCol + 1] - '0');
                        bakery[sellerRow, sellerCol] = '-';
                        bakery[sellerRow, sellerCol + 1] = 'S';
                        sellerCol++;
                        if (collectedMoney >= 50)
                        {
                            break;
                        }
                    }
                    else if (bakery[sellerRow, sellerCol + 1] == 'O')
                    {
                        if (sellerRow == pillarOneRow && sellerCol + 1 == pillarOneCol)
                        {
                            bakery[sellerRow, sellerCol] = '-';
                            bakery[sellerRow, sellerCol + 1] = '-';
                            bakery[pillarTwoRow, pillarTwoCol] = 'S';
                            sellerRow = pillarTwoRow;
                            sellerCol = pillarTwoCol;
                        }
                        else
                        {
                            bakery[sellerRow, sellerCol] = '-';
                            bakery[sellerRow, sellerCol + 1] = '-';
                            bakery[pillarOneRow, pillarOneCol] = 'S';
                            sellerRow = pillarOneRow;
                            sellerCol = pillarOneCol;
                        }
                    }
                    else if (bakery[sellerRow, sellerCol + 1] == '-')
                    {
                        bakery[sellerRow, sellerCol] = '-';
                        bakery[sellerRow, sellerCol + 1] = 'S';
                        sellerCol++;
                    }
                }
            }

            if (isOutside)
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            else if (collectedMoney >= 50)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }

            Console.WriteLine($"Money: {collectedMoney}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(bakery[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
