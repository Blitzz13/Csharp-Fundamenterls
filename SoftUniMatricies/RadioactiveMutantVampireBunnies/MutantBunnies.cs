using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveMutantVampireBunnies
{
    class MutantBunnies
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            char[,] matrix = new char[rows, cols];
            char[,] matrixBunny = new char[rows, cols];

            //Making field
            PopulateMatrix(rows, cols, matrix, matrixBunny);

            int playerRow = 0;
            int playerCol = 0;

            //finding player's coordinates
            FindPlayer(rows, cols, matrix, ref playerRow, ref playerCol);

            char[] commands = Console.ReadLine().ToCharArray();
            int turn = 0;
            bool win = false, loose = false;
            //player and bunnies taking turns
            for (int i = 0; i < commands.Length; i++)
            {
                //Player turn
                #region Player
                if (commands[turn] == 'L')
                {
                    matrixBunny[playerRow, playerCol] = '.';
                    playerCol--;
                    if (playerCol < 0)
                    {
                        playerCol += 1;
                        win = true;
                    }
                    else if (matrixBunny[playerRow, playerCol] == 'B')
                    {
                        loose = true;
                    }
                    else
                    {
                        matrixBunny[playerRow, playerCol] = 'P';
                    }
                }
                if (commands[turn] == 'R')
                {
                    matrixBunny[playerRow, playerCol] = '.';
                    playerCol++;
                    if (playerCol >= cols)
                    {
                        playerCol -= 1;
                        win = true;
                    }
                    else if (matrixBunny[playerRow, playerCol] == 'B')
                    {
                        loose = true;
                    }
                    else
                    {
                        matrixBunny[playerRow, playerCol] = 'P';
                    }
                }
                if (commands[turn] == 'U')
                {
                    matrixBunny[playerRow, playerCol] = '.';
                    playerRow--;
                    if (playerRow < 0)
                    {
                        playerRow += 1;
                        win = true;
                    }
                    else if (matrixBunny[playerRow, playerCol] == 'B')
                    {
                        loose = true;
                    }
                    else
                    {
                        matrixBunny[playerRow, playerCol] = 'P';
                    }
                }
                if (commands[turn] == 'D')
                {
                    matrixBunny[playerRow, playerCol] = '.';
                    playerRow++;
                    if (playerRow >= rows)
                    {
                        playerRow -= 1;
                        win = true;
                    }
                    else if (matrixBunny[playerRow, playerCol] == 'B')
                    {
                        loose = true;
                    }
                    else
                    {
                        matrixBunny[playerRow, playerCol] = 'P';
                    }
                }
                #endregion

                //Bunnies turn
                #region Bunnies
                for (int rowIndex = 0; rowIndex < rows; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < cols; colIndex++)
                    {

                        if (matrix[rowIndex, colIndex] == 'B')
                        {
                            if (rowIndex > 0)
                            {
                                if (matrixBunny[rowIndex - 1, colIndex] == 'P')
                                {
                                    loose = true;
                                }
                                matrixBunny[rowIndex - 1, colIndex] = 'B';
                            }
                            if (rowIndex < rows - 1)
                            {
                                if (matrixBunny[rowIndex + 1, colIndex] == 'P')
                                {
                                    loose = true;
                                }
                                matrixBunny[rowIndex + 1, colIndex] = 'B';
                            }
                            if (colIndex > 0)
                            {
                                if (matrixBunny[rowIndex, colIndex - 1] == 'P')
                                {
                                    loose = true;
                                }
                                matrixBunny[rowIndex, colIndex - 1] = 'B';
                            }
                            if (colIndex < cols - 1)
                            {
                                if (matrixBunny[rowIndex, colIndex + 1] == 'P')
                                {
                                    loose = true;
                                }
                                matrixBunny[rowIndex, colIndex + 1] = 'B';
                            }
                        }


                    }
                }

                TransferMatrix(rows, cols, matrix, matrixBunny);
                #endregion
                if (win || loose)
                {
                    break;
                }
                turn++;
            }

            PrintMatrix(rows, cols, matrixBunny);

            if (win)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else if (loose)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
        }

        private static void PopulateMatrix(int rows, int cols, char[,] matrix, char[,] matrixBunny)
        {
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    matrix[rowIndex, colIndex] = line[colIndex];
                    matrixBunny[rowIndex, colIndex] = line[colIndex];

                }
            }
        }

        private static void FindPlayer(int rows, int cols, char[,] matrix, ref int playerRow, ref int playerCol)
        {
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    if (matrix[rowIndex, colIndex] == 'P')
                    {
                        playerRow = rowIndex;
                        playerCol = colIndex;
                    }
                }
            }
        }

        private static void TransferMatrix(int rows, int cols, char[,] matrix, char[,] matrixBunny)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = matrixBunny[row, col];
                }
            }
        }

        private static void PrintMatrix(int x, int y, char[,] matrix)
        {
            for (int row = 0; row < x; row++)
            {
                for (int col = 0; col < y; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }

    }
}
