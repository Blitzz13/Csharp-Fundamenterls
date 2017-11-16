using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFunction
{
    class TriFunction
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            for (int i = 0; i < names.Length; i++)
            {
                var name = names[i].ToCharArray();
                int sum = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    sum += name[j];
                }
                if (sum >= lenght)
                {
                    Console.WriteLine(names[i]);
                    break;
                }
            }
        }
    }
}
