using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] {' ', ','},StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine();

            for (int i = 0; i < arr.Length; i++)
            {
                text = text.Replace(arr[i], new string('*', arr[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
