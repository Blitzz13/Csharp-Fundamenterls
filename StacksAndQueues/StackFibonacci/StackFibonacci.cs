using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackFibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            var stack = new Stack<long>();

            stack.Push(0);
            stack.Push(1);
            long n = long.Parse(Console.ReadLine());

            int count = 1;
            while (count != n)
            {
                long x = stack.Pop();
                long y = stack.Pop();
                long z = x + y;
                stack.Push(x);
                stack.Push(z);
                count++;
            }

            Console.WriteLine(stack.Peek());
        }
    }
}
