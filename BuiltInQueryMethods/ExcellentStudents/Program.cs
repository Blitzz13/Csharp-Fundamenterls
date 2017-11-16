using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentStudents
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<string>();
            int count = 0;
            while (input != "END")
            {
                var tokens = input.Split();

                for (int i = 2; i < tokens.Length; i++)
                {
                    if (int.Parse(tokens[i]) <= 3)
                    {
                        count++;
                        if (count >= 2)
                        {
                            students.Add(tokens[0] + " " + tokens[1]);
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\r\n",students));

        }
    }
}
