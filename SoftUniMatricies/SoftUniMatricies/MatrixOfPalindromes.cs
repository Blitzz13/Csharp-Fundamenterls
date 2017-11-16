using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniMatricies
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int r = tokens[0];
            int c = tokens[1];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string[,] matrix = new string[r, c];

            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    string word = alphabet[row].ToString() + alphabet[col+row] + alphabet[row];
                    matrix[row, col] = word;
                }
            }

            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
