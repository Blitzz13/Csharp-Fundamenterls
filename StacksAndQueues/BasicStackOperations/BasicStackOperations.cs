using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            double[] tokens = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
                .ToArray();

            double pushCount = tokens[0];
            double popCount = tokens[1];
            double elementToFind = tokens[2];

            var stack = new Stack<double>();
            double[] arr = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
                .ToArray();
            for (int i = 0; i < pushCount; i++)
            {
                stack.Push(arr[i]);
            }

            for (int i = 0; i < popCount; i++)
            {
                stack.Pop();
            }
            try
            {
                if (stack.Contains(elementToFind))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            catch
            {
                Console.WriteLine("0");
            }
            
        }       
    }
}
