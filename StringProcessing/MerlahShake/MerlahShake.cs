using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerlahShake
{
    class MerlahShake
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                int firstIndex = text.IndexOf(pattern);
                int lastIndex = text.LastIndexOf(pattern);

                if (firstIndex == -1 || lastIndex == firstIndex)
                {
                    break;
                }

                text = text.Remove(lastIndex, pattern.Length);
                text = text.Remove(firstIndex, pattern.Length);

                Console.WriteLine("Shaked it.");
                if (pattern.Length > 1)
                {
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    break;
                }
                
            }

            Console.WriteLine("No shake." + Environment.NewLine + text);
        }
    }
}
