using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossfire
{
    class Crossfire
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = sizes[0];
            int y = sizes[1];

            List<List<int>> matrix = new List<List<int>>();
            List<int> line = new List<int>();
            int counter = 1;
            for (int rows = 0; rows < y; rows++)
            {
                for (int cols = 0; cols < x; cols++)
                {
                    line.Add(counter);
                    counter++;
                }
                matrix.Add(line);
                line = new List<int>();
            }

            string[] explosion = Console.ReadLine().Split().ToArray();
            while (string.Join(" ",explosion) != "Nuke it from orbit")
            {
                int explosionRow = int.Parse(explosion[0]);
                int explosionCol = int.Parse(explosion[1]);
                int explosionRange = int.Parse(explosion[2]);
                int count = explosionRange;
                try
                {
                    matrix[explosionRow][explosionCol] = 0;
                }
                catch
                {
                }
                
                for (int i = 0; i < count; i++)
                {
                    try
                    {
                        if (explosionRow + explosionRange <= matrix.Count - 1 && explosionCol < matrix[explosionRow + explosionRange].Count)
                        {
                            matrix[explosionRow + explosionRange][explosionCol] = 0;
                        }
                        if (explosionRow - explosionRange >= 0 && explosionCol < matrix[explosionRow - explosionRange].Count)
                        {
                            matrix[explosionRow - explosionRange][explosionCol] = 0;
                        }
                        if (explosionCol + explosionRange < matrix[explosionRow].Count)
                        {
                            matrix[explosionRow][explosionCol + explosionRange] = 0;
                        }
                        if (explosionCol - explosionRange < matrix[explosionRow].Count)
                        {
                            matrix[explosionRow][explosionCol - explosionRange] = 0;
                        }
                    }
                    catch
                    {
                        
                    }
                    
                    explosionRange--;
                }
                for (int rows = 0; rows < matrix.Count; rows++)
                {
                    for (int cols = 0; cols < matrix[rows].Count; cols++)
                    {
                        if (matrix[rows][cols] == 0)
                        {
                            matrix[rows].RemoveAt(cols);
                            cols--;
                        }
                    }
                }
                explosion = Console.ReadLine().Split().ToArray();

            }

            for (int rows = 0; rows < matrix.Count; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Count; cols++)
                {
                    Console.Write($"{matrix[rows][cols]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
