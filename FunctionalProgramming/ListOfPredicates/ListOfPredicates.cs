using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfPredicates
{
    class ListOfPredicates
    {
        static void Main(string[] args)
        {
            var n =int.Parse(Console.ReadLine());

            var list = new List<int>();
            var newList = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }

            var comapareArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isDivisable = false;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < comapareArr.Length; j++)
                {
                    if (list[i] % comapareArr[j] == 0)
                    {
                        if (j == comapareArr.Length - 1)
                        {
                            newList.Add(list[i]);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",newList));
        }
    }
}
