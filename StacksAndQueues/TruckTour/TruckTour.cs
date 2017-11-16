using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            long linesCount = long.Parse(Console.ReadLine());
            List<List<long>> allPumps = new List<List<long>>();
            List<long> line = new List<long>();
            for (int i = 0; i < linesCount; i++)
            {
                line = Console.ReadLine().Split().Select(long.Parse).ToList();
                allPumps.Add(line);
            }
            long fuel = -1;
            int stationNumber = int.MinValue;
            int counter = 0;
            for (int i = 0; i < allPumps.Count; i++)
            {
                if (allPumps[i][0] >= allPumps[i][1] || fuel >= 0)
                {
                    fuel += allPumps[i][0] - allPumps[i][1];
                    if (counter == 0)
                    {
                        stationNumber = i;
                    }
                    counter++;
                }
                else
                {
                    stationNumber = int.MinValue;
                    counter = 0;
                }
            }

            if (stationNumber == int.MinValue)
            {
                stationNumber = allPumps.Count;
            }
            Console.WriteLine(stationNumber);
        }
    }
}
