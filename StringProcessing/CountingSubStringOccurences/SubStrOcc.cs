using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSubStringOccurences
{
    class SubStrOcc
    {
        static void Main(string[] args)
        {
            String text = Console.ReadLine().ToLower();
            String searchStr = Console.ReadLine().ToLower();

            int count = 0;
            int i = 0;

            while (text.IndexOf(searchStr, i) != -1)
            {
                count++;
                i = text.IndexOf(searchStr, i) + 1;
            }

            Console.WriteLine(count);
        }
    }
}
