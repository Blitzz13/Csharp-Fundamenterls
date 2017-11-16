using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePartyReservationFilterModule
{
    class ThePartyReservationFilterModule
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();

            var line = Console.ReadLine().Split();
            var addCommands = new List<string>();
            var removeCommands = new List<string>();
            while (line.Length != 1)
            {
                if (line[0] == "Add")
                {
                    addCommands.Add(String.Join(" ", line));
                }
                else
                {
                    removeCommands.Add(String.Join(" ", line));
                }
                line = Console.ReadLine().Split();
            }

            var commands = new List<string>();
            if (removeCommands.Count != 0)
            {
                for (int i = 0; i < addCommands.Count; i++)
                {
                    string command = addCommands[i].Split(';')[1];
                    string param = addCommands[i].Split(';')[2];

                    for (int j = 0; j < removeCommands.Count; j++)
                    {
                        var tokens = removeCommands[j].Split(';');
                        string secCommand = tokens[1];
                        string secParam = tokens[2];

                        if ((command != secCommand || secParam != param) && j == removeCommands.Count - 1)
                        {
                            commands.Add(addCommands[i]);
                        }
                    }
                }

            }
            else
            {
                commands.AddRange(addCommands);
            }

            for (int i = 0; i < commands.Count; i++)
            {
                string command = commands[i].Split(';')[1];
                string param = commands[i].Split(';')[2];

                switch (command)
                {
                    case "Starts with":
                        names.RemoveAll(a => a.StartsWith(param));
                        break;
                    case "Ends with":
                        names.RemoveAll(a => a.EndsWith(param));
                        break;
                    case "Length":
                        names.RemoveAll(a => a.Length == int.Parse(param));
                        break;
                    case "Contains":
                        names.RemoveAll(a => a.Contains(param));
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
