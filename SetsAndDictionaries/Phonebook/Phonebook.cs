using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, string>();

            var tokens = Console.ReadLine().Split('-').ToList();
            while (tokens.Count > 1)
            {
                var name = tokens[0];
                var phoneNumber = tokens[1];

                if (!phoneBook.ContainsKey(name))
                {
                    phoneBook.Add(name, phoneNumber);
                }
                else
                {
                    phoneBook[name] = phoneNumber;
                }

                tokens = Console.ReadLine().Split('-').ToList();
            }


            var command = Console.ReadLine();
            while (command != "stop")
            {
                if (phoneBook.ContainsKey(command))
                {
                    Console.WriteLine($"{command} -> {phoneBook[command]}");
                }
                else
                {
                    Console.WriteLine($"Contact {command} does not exist.");
                }

                command = Console.ReadLine();
            }
        }
    }
}

