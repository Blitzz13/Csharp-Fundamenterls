using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{stack.Pop()} ");
            }


        }
    }
}
