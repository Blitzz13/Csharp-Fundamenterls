using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateParty
{
    class PredicateParty
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();

            var line = Console.ReadLine().Split();
            while (string.Join("", line) != "Party!")
            {
                string command = line[0];
                string criteria = line[1];
                string param = line[2];

                if (command == "Remove")
                {
                    switch (criteria)
                    {
                        case "StartsWith":
                            names.RemoveAll(a => a.StartsWith(param));
                            break;
                        case "EndsWith":
                            names.RemoveAll(a => a.EndsWith(param));
                            break;
                        case "Length":
                            names.RemoveAll(a => a.Length == int.Parse(param));
                            break;
                    }
                }
                else
                {
                    switch (criteria)
                    {
                        case "StartsWith":
                            for (int i = 0; i < names.Count; i++)
                            {
                                if (names[i].StartsWith(param))
                                {
                                    names.Insert(i, names[i]);
                                    i++;
                                }
                            }
                            break;
                        case "EndsWith":
                            for (int i = 0; i < names.Count; i++)
                            {
                                if (names[i].EndsWith(param))
                                {
                                    names.Insert(i, names[i]);
                                    i++;
                                }
                            }
                            break;
                        case "Length":
                            for (int i = 0; i < names.Count; i++)
                            {
                                if (names[i].Length == int.Parse(param))
                                {
                                    names.Insert(i, names[i]);
                                    i++;
                                }
                            }
                            break;
                    }
                }

                line = Console.ReadLine().Split();
            }

            if (names.Count > 0)
            {
                Console.WriteLine($"{String.Join(", ",names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
