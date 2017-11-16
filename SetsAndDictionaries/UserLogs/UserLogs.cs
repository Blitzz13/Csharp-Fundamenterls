using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var messageTokens = line.Split(' ');
                var ip = messageTokens[0].Replace("IP=","");
                var userName = messageTokens[2].Replace("user=","");
                if (users.ContainsKey(userName))
                {
                    if (users[userName].ContainsKey(ip))
                    {
                        users[userName][ip] += 1;
                    }
                    else
                    {
                        users[userName][ip] = 1;
                    }
                    
                }
                else
                {
                    users[userName] = new Dictionary<string, int> {{ip, 1}};
                }
                line = Console.ReadLine();
            }

            PrintUsersAndIps(users);
        }

        private static void PrintUsersAndIps(SortedDictionary<string, Dictionary<string, int>> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}:");
                Console.WriteLine("{0}.", string.Join(", ",user.Value.Select(a => $"{a.Key} => {a.Value}")));
            }
        }
    }
}
