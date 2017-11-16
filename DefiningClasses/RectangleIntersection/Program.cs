using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangles = new Dictionary<string, Rectangle>();

            var inputInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < inputInfo[0]; i++)
            {
                var rectagleInfo = Console.ReadLine().Split();
                var id = rectagleInfo[0];
                var width = double.Parse(rectagleInfo[1]);
                var height = double.Parse(rectagleInfo[2]);
                var topLeftHoriz = double.Parse(rectagleInfo[3]);
                var topLeftVert = double.Parse(rectagleInfo[4]);

                var rectangle = new Rectangle(id, width, height, topLeftHoriz, topLeftVert);
                rectangles[id] = rectangle;
            }

            for (int i = 0; i < inputInfo[1]; i++)
            {
                var checkIDs = Console.ReadLine().Split();
                var result = rectangles[checkIDs[0]].IntesectsWith(rectangles[checkIDs[1]]);
                Console.WriteLine(result.ToString().ToLower());
            }
        }
    }
}
