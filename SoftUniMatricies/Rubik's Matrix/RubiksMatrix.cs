using System;
using System.Linq;

namespace Rubik_s_Matrix
{
    class RubiksMatrix
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];


            int[][] matrix = new int[rows][];
            int counter = 1;
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = new int[cols];
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    matrix[rowIndex][colIndex] = counter;
                    counter++;
                }
            }

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int rowOrColIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int moves = int.Parse(tokens[2]);

                switch (direction)
                {
                    case "up":
                        MoveCol(matrix, rowOrColIndex, moves);
                        break;
                    case "down":
                        MoveCol(matrix, rowOrColIndex,rows - moves % rows);
                        break;
                    case "left":
                        MoveRow(matrix, rowOrColIndex, moves);
                        break;
                    case "right":
                        MoveRow(matrix, rowOrColIndex,cols - moves % cols);
                        break;

                }

            }
                int element = 1;
                for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < matrix[0].Length; colIndex++)
                    {
                        if (matrix[rowIndex][colIndex] == element)
                        {
                            Console.WriteLine("No swap required");
                        }
                        else
                        {
                            for (int r = 0; r < matrix.Length; r++)
                            {
                                for (int c = 0; c < matrix[0].Length; c++)
                                {
                                    if (matrix[r][c] == element)
                                    {
                                        var currentElement = matrix[rowIndex][colIndex];
                                        matrix[rowIndex][colIndex] = element;
                                        matrix[r][c] = currentElement;
                                        Console.WriteLine($"Swap ({rowIndex}, {colIndex}) with ({r}, {c})");
                                        break;
                                    }
                                }
                            }
                        }
                        element++;
                    }
                }

        }

        private static void MoveRow(int[][] matrix, int rowOrColIndex, int moves)
        {
            int[] temp = new int[matrix[0].Length];
            for (int colIndex = 0; colIndex < matrix[0].Length; colIndex++)
            {
                temp[colIndex] = matrix[rowOrColIndex][(colIndex + moves) % matrix[0].Length];
            }

            matrix[rowOrColIndex] = temp;
        }

        private static void MoveCol(int[][] matrix, int rowOrColIndex, int moves)
        {
            int[] temp = new int [matrix.Length];
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                temp[rowIndex] = matrix[(rowIndex + moves) % matrix.Length][rowOrColIndex];
            }

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex][rowOrColIndex] = temp[rowIndex];
            }
        }

        private static void PrintMatrix(int x, int y, int[,] matrix)
        {
            for (int row = 0; row < x; row++)
            {
                for (int col = 0; col < y; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

    }
}
