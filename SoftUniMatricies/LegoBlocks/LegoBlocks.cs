using System;
using System.Collections.Generic;
using System.Linq;

namespace LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            List<List<string>> matrix = new List<List<string>>();
            List<string> row = new List<string>();

            for (int j = 1; j <= 2 * n; j++)
            {
                row = Console.ReadLine().Trim().Split(' ').ToList(); 
                matrix.Add(row);
            }

            bool fit = true;

            for (int i = 1; i < n; i++)
            {
                if (matrix[i].Count + matrix[i + n].Count != matrix[i - 1].Count + matrix[i - 1 + n].Count)
                {
                    fit = false;
                    break;
                }
            }

            if (fit)
            {
                for (int i = 0; i < n; i++)
                {
                    matrix[i + n].Reverse();
                    Console.WriteLine("[" + string.Join(", ", matrix[i]) + ", " +
                                      string.Join(", ", matrix[i + n].ToList()) + "]");
                }
            }
            else
            {
                int sum = 0;

                for (int i = 0; i < (2 * n); i++)
                {
                    sum += matrix[i].Count;
                }

                Console.WriteLine("The total number of cells is: {0}", sum);
            }
        }
    }
}
