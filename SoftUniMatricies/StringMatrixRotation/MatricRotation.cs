using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringMatrixRotation
{
    class MatricRotation
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string pattern = @"Rotate\(([0-9]+)\)";
            Match match = Regex.Match(line, pattern);

            int number = int.Parse(match.Groups[1].Value);

            char[] element = Console.ReadLine().ToCharArray();
            List<List<char>> matrix = new List<List<char>>();
            List<char> row = new List<char>();
            int longestLenght = 0;
            while (string.Join("", element) != "END")
            {
                row.AddRange(element);
                matrix.Add(row);
                row = new List<char>();
                element = Console.ReadLine().ToCharArray();
                if (element.Length > longestLenght)
                {
                    longestLenght = element.Length;
                }
            }

            if (number > 360)
            {
                number %= 360;
            }

            if (number == 0)
            {
                for (int rowIndex = 0; rowIndex < matrix.Count; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < matrix[rowIndex].Count; colIndex++)
                    {
                        Console.Write(matrix[rowIndex][colIndex]);
                    }

                    Console.WriteLine();
                }
            }
            else if (number == 90)
            {
                List<List<char>> newMatrix = new List<List<char>>();
                List<char> newRow = new List<char>();
                for (int rowIndex = 0; rowIndex < longestLenght; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < matrix.Count; colIndex++)
                    {
                        try
                        {
                            newRow.Add(matrix[colIndex][rowIndex]);
                        }
                        catch
                        {
                            newRow.Add(' ');
                        }
                           
                    }
                    newRow.Reverse();
                    newMatrix.Add(newRow);
                    newRow = new List<char>();
                }
                for (int rowIndex = 0; rowIndex < longestLenght; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < newMatrix[rowIndex].Count; colIndex++)
                    {
                        Console.Write(newMatrix[rowIndex][colIndex]);
                    }
                    Console.WriteLine();
                }
            }
            else if(number == 180)
            {
                //reverse
                for (int rowIndex = 0; rowIndex < matrix.Count; rowIndex++)
                {
                    matrix[rowIndex].Reverse();
                }

                for (int rowIndex = matrix.Count - 1; rowIndex >= 0; rowIndex--)
                {
                    for (int colIndex = 0; colIndex < matrix[rowIndex].Count; colIndex++)
                    {
                        Console.Write(matrix[rowIndex][colIndex]);
                    }

                    Console.WriteLine();
                }
            }
            else if (number == 270)
            {
                List<List<char>> newMatrix = new List<List<char>>();
                List<char> newRow = new List<char>();
                for (int rowIndex = 0; rowIndex < longestLenght; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < matrix.Count; colIndex++)
                    {
                        try
                        {
                            newRow.Add(matrix[colIndex][rowIndex]);
                        }
                        catch
                        {
                            newRow.Add(' ');
                        }

                    }
                    newMatrix.Add(newRow);
                    newRow = new List<char>();
                }

                for (int rowIndex = longestLenght - 1; rowIndex >= 0; rowIndex--)
                {
                    for (int colIndex = 0; colIndex < newMatrix[rowIndex].Count; colIndex++)
                    {
                        Console.Write(newMatrix[rowIndex][colIndex]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
