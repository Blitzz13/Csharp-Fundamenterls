using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palendromes
{
    class Palendromes
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().
                Split(new char[] { ' ', ',', '.', '!', '?' },
                    StringSplitOptions.RemoveEmptyEntries);

            SortedSet<string> palendromes = new SortedSet<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string reversed = Reverse(input[i]);
                if (input[i] == reversed)
                {
                    palendromes.Add(input[i]);
                }
            }

            Console.Write("[");
            Console.Write(string.Join(", ",palendromes));
            Console.WriteLine("]");
        }

        static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
