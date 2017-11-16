using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                if (input.Length > 1)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        set.Add(input[j]);
                    }
                }
                else
                {
                    set.Add(input[0]);
                }
               
                   
                
            }

            foreach (var element in set)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
