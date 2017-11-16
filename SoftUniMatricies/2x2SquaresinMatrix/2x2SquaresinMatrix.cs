using System;
using System.Linq;

namespace _2x2SquaresinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = tokens[0];
            int col = tokens[1];
            string[,] matrix = new string[row, col];

            for (int r = 0; r < row; r++)
            {
                string[] line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int c = 0; c < col; c++)
                {
                    matrix[r, c] = line[c];
                }
            }

            int counter = 0;
            for (int r = 0; r < row - 1; r++)
            {
                for (int c = 0; c < col - 1; c++)
                {
                    string left = matrix[r, c];
                    string right = matrix[r, c + 1];
                    string downLeft = matrix[r + 1, c];
                    string downRight = matrix[r + 1, c + 1];
                    if (left == right && downLeft == downRight && left == downLeft)
                    {
                        counter++;
                    }
                }
            }

           
            Console.WriteLine(counter);
        }
    }
}
