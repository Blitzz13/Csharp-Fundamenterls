using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLenght
{
    class StringLenght
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input.Length > 20)
            {
                Console.WriteLine(input.Remove(20, input.Length - 20));
            }
            else
            {
                
                Console.WriteLine(input.PadRight(20, '*'));
            }
        }
    }
}
