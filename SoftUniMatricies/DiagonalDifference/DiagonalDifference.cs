using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal[,] matrix = new decimal[n, n];

;           for (int row = 0; row < n; row++)
            {
                decimal[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = tokens[col];
                }
            }

            decimal leftDiagonalSum = 0;
            for (int row = 0; row < n; row++)
            {
                leftDiagonalSum += matrix[row, row];
            }

            decimal rightDiagonalSum = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = n - 1; col >= 0; col--)
                {
                    if (col + row == n - 1)
                    {
                        rightDiagonalSum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(Math.Abs(leftDiagonalSum - rightDiagonalSum));
        }
    }
}
