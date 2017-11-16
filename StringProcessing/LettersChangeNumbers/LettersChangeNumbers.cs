using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[]{'\t',' '},StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var newInput = input[i];
                char firstLetter = newInput.First();
                char lastLetter = newInput.Last();
                newInput = newInput.Remove(0, 1);
                newInput = newInput.Remove(newInput.Length - 1, 1);
                var number = double.Parse(newInput);

                if (char.IsUpper(firstLetter))
                {
                    int index = char.ToUpper(firstLetter) - 64;
                    number /= index;
                }
                else if (char.IsLower(firstLetter))
                {
                    int index = char.ToUpper(firstLetter) - 64;
                    number *= index;
                }

                if (char.IsUpper(lastLetter))
                {
                    int index = char.ToUpper(lastLetter) - 64;
                    number -= index;
                }
                else if (char.IsLower(lastLetter))
                {
                    int index = char.ToUpper(lastLetter) - 64;
                    number += index;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
