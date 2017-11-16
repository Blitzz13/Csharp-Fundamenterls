using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            int enqueueCount = tokens[0];
            int denqueueCount = tokens[1];
            int elementToFind = tokens[2];

            var queue = new Queue<double>();

            double[] arr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
                .ToArray();
            for (int i = 0; i < enqueueCount; i++)
            {
                queue.Enqueue(arr[i]);
            }

            for (int i = 0; i < denqueueCount; i++)
            {
                queue.Dequeue();
            }

            try
            {
                if (queue.Contains(elementToFind))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            catch
            {
                Console.WriteLine("0");
            }
        }
    }
}
