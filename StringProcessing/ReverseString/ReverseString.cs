using System;
using System.Linq;
using System.Text;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            
            Console.WriteLine(sb);
        }
    }
}
