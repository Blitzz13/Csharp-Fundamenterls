using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            var parentheses = Console.ReadLine();

            var openedParetheses = new Stack<char>();
            var openingCases = new [] {'{', '[', '('};
            bool mismatch = false;

            for (int i = 0; i < parentheses.Length; i++)
            {
                if (openingCases.Contains(parentheses[i]))
                {
                    openedParetheses.Push(parentheses[i]);
                }
                else
                {
                    if (!openedParetheses.Any())
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (parentheses[i])
                    {
                        case '}':
                            if (openedParetheses.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (openedParetheses.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ')':
                            if (openedParetheses.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
