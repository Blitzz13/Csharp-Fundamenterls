using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            var line = Console.ReadLine();

            while (line != "end")
            {
                if (line == "add")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] += 1;
                    }
                }
                else if (line == "multiply")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] *= 2;
                    }
                }
                else if (line == "subtract")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] -= 1;
                    }
                }
               

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
