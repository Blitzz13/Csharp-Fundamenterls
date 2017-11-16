using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfernoIII
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.Insert(0, 0);
            numbers.Insert(numbers.Count, 0);
            var line = Console.ReadLine().Split(';');
            var excludeCommands = new List<string>();
            var reverseCommands = new List<string>();
            while (line.Length != 1)
            {
                if (line[0] == "Exclude")
                {
                    excludeCommands.Add(String.Join(";", line));
                }
                else
                {
                    reverseCommands.Add(String.Join(";", line));
                }

                line = Console.ReadLine().Split(';');
            }

            var commands = new List<string>();
            if (reverseCommands.Count != 0)
            {
                for (int i = 0; i < excludeCommands.Count; i++)
                {
                    string command = excludeCommands[i].Split(';')[1];
                    string param = excludeCommands[i].Split(';')[2];

                    for (int j = 0; j < reverseCommands.Count; j++)
                    {
                        var tokens = reverseCommands[j].Split(';');
                        string secCommand = tokens[1];
                        string secParam = tokens[2];

                        if ((command != secCommand || secParam != param) && j == reverseCommands.Count - 1)
                        {
                            commands.Add(excludeCommands[i]);
                        }
                    }
                }

            }
            else
            {
                commands.AddRange(excludeCommands);
            }

            for (int i = 0; i < commands.Count; i++)
            {
                string command = commands[i].Split(';')[1];
                string param = commands[i].Split(';')[2];

                switch (command)
                {
                    case "Sum Left":
                        for (int j = 1; j < numbers.Count - 1; j++)
                        {
                            if (numbers[j] + numbers[j - 1] == int.Parse(param))
                            {
                                numbers.Remove(numbers[j]);
                                j--;
                            }
                        }
                        break;
                    case "Sum Right":
                        for (int j = 1; j < numbers.Count - 1; j++)
                        {
                            if (numbers[j] + numbers[j + 1] == int.Parse(param))
                            {
                                numbers.Remove(numbers[j]);
                                j--;
                            }
                        }
                        break;
                    case "Sum Left Right":
                        for (int j = 1; j < numbers.Count - 1; j++)
                        {
                            if (numbers[j] + numbers[j + 1] + numbers[j - 1] == int.Parse(param))
                            {
                                numbers.Remove(numbers[j]);
                                j--;
                            }
                        }
                        break;
                }
            }

            numbers.RemoveAt(0);
            numbers.RemoveAt(numbers.Count - 1);

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
