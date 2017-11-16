using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiamlSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = tokens[0];
            int m = tokens[1];
            int[,] ma = new int [n, m];
            for (int row = 0; row < n; row++)
            {
                tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < m; col++)
                {
                   int number = tokens[col];
                   ma[row, col] = number;
                }
            }
            int bestSum = int.MinValue;
            for (int r = 0; r < ma.GetLength(0) - 2; r++)
            {
                for (int c = 0; c < ma.GetLength(1) - 2; c++)
                {
                    int sum =
                        ma[r, c] + ma[r, c + 1] + ma[r, c + 2]
                        + ma[r + 1, c] + ma[r + 1, c + 1] + ma[r + 1, c + 2]
                        + ma[r + 2, c] + ma[r + 2, c + 1] + ma[r + 2, c + 2];
                    if (bestSum < sum)
                    {
                        bestSum = sum;
                    }
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
