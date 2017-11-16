using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int x = size[0];
            int y = size[1];

            int[,] matrix = new int[x, y];

            for (int r = 0; r < x; r++)
            {
                int[] tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int c = 0; c < y; c++)
                {
                    matrix[r, c] = tokens[c];
                }
            }

            int counter = 0;
            int[,] maximalMatrix = new int[3, 3];
            int maximalSum = int.MinValue;
            for (int r = 0; r < x - 2; r++)
            {
                for (int c = 0; c < y - 2; c++)
                {
                    int row1col1 = matrix[r, c];
                    int row1col2 = matrix[r, c + 1];
                    int row1col3 = matrix[r, c + 2];
                    int row2col1 = matrix[r + 1, c];
                    int row2col2 = matrix[r + 1, c + 1];
                    int row2col3 = matrix[r + 1, c + 2];
                    int row3col1 = matrix[r + 2, c];
                    int row3col2 = matrix[r + 2, c + 1];
                    int row3col3 = matrix[r + 2, c + 2];
                    int currentSum = row1col1 + row1col2 + row1col3 +
                                     row2col1 + row2col2 + row2col3 +
                                     row3col1 + row3col2 + row3col3;

                    if (currentSum > maximalSum)
                    {
                        maximalSum = currentSum;
                        maximalMatrix[0, 0] = row1col1;
                        maximalMatrix[0, 1] = row1col2;
                        maximalMatrix[0, 2] = row1col3;
                        maximalMatrix[1, 0] = row2col1;
                        maximalMatrix[1, 1] = row2col2;
                        maximalMatrix[1, 2] = row2col3;
                        maximalMatrix[2, 0] = row3col1;
                        maximalMatrix[2, 1] = row3col2;
                        maximalMatrix[2, 2] = row3col3;
                    }

                }
            }

            Console.WriteLine($"Sum = {maximalSum}");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"{maximalMatrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
