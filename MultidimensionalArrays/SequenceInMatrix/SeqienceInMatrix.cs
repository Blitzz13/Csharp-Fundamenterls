using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
{
    class SeqienceInMatrix
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split().ToArray();
            int n = int.Parse(tokens[0]);
            int m = int.Parse(tokens[1]);
            string[,] matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                tokens = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < m; col++)
                {
                    string str = tokens[col];
                    matrix[row, col] = str;
                }
            }

            //Best sqecuence in the rows
            int bestRowSequence = 0;
            for (int row = 0; row < n; row++)
            {
                int rowSequence = 0;
                for (int col = 0; col < m - 1; col++)
                {
                    string currentStr = matrix[row, col];
                    string nextStr = matrix[row, col + 1];

                    if (currentStr == nextStr)
                    {
                        rowSequence++;
                        if (rowSequence > bestRowSequence)
                        {
                            bestRowSequence = rowSequence;
                        }
                    }
                    else
                    {
                        rowSequence = 0;
                    }


                }
            }

            //Best sqecuence in the columns
            int bestColSequence = 0;
            for (int col = 0; col < m; col++)
            {
                int colSequence = 0;
                for (int row = 0; row < n - 1; row++)
                {
                    string currentStr = matrix[row, col];
                    string nextStr = matrix[row + 1, col];

                    if (currentStr == nextStr)
                    {
                        colSequence++;
                        if (colSequence > bestRowSequence)
                        {
                            bestColSequence = colSequence;
                        }
                    }
                    else
                    {
                        colSequence = 0;
                    }

                }

            }

            //Best sqecuence in the diagonal
            int bestDiagonalSequence;
            int x = 0;
            int y = 0;
            for (int row = 0; row < n; row++)
            {
                string currentStr = matrix[x, y];
                string nextStr = matrix[x, y];
                int diagonalSequence = 0;
                if (currentStr == nextStr)
                {
                    
                    diagonalSequence++;
                    if (diagonalSequence > bestRowSequence)
                    {
                        bestDiagonalSequence = diagonalSequence;
                    }
                }
                else
                {
                    diagonalSequence = 0;
                }
                x++;
                y++;
            }

        }
    }
}
