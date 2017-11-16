using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class LogsAggregator
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, UserDetails> users = new Dictionary<string, UserDetails>();
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                string ip = tokens[0];
                string user = tokens[1];
                int time = int.Parse(tokens[2]);

                if (!users.ContainsKey(user))
                {
                    UserDetails userdetails = new UserDetails
                    {
                        ips = new List<string> { ip },
                        duration = time
                    };

                    users.Add(user, userdetails);
                }
                else
                {
                    if (!users[user].ips.Contains(ip))
                    {
                        users[user].ips.Add(ip);
                    }
                    users[user].duration += time;
                }
            }

            foreach (var user in users.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{user.Key}: {user.Value.duration} [{string.Join(", ", user.Value.ips.OrderBy(a => a))}]");
            }
        }
    }

    class UserDetails
    {
        public int duration { get; set; }
        public List<string> ips { get; set; }
    }
}
