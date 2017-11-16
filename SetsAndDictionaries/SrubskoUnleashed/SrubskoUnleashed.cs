using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SrubskoUnleashed
{
    class SrubskoUnleashed
    {
        static void Main(string[] args)
        {
            var venues = new Dictionary<string, Dictionary<string, int>>();
            
            var line = Console.ReadLine();

            while (line != "End")
            {
                var venueTokens = line.Split(new[] { " @" }, StringSplitOptions.RemoveEmptyEntries);

                if (!(venueTokens.Length > 1))
                {
                    line = Console.ReadLine();
                    continue;
                }
                var singer = venueTokens[0];

                var venueAndTickets = venueTokens[1].Split();
                var ticketPrice = 0;
                var ticketCount = 0;
                try
                {
                    ticketPrice = int.Parse(venueAndTickets[venueAndTickets.Length - 2]);
                    ticketCount = int.Parse(venueAndTickets[venueAndTickets.Length - 1]);

                }
                catch
                {
                    line = Console.ReadLine();
                    continue;
                }

                var venue = new StringBuilder();
                for (int i = 0; i < venueAndTickets.Length - 2; i++)
                {
                    venue.Append(venueAndTickets[i]);
                    venue.Append(" ");
                }

                if (venues.ContainsKey(venue.ToString()))
                {
                    if (venues[venue.ToString()].ContainsKey(singer))
                    {
                        venues[venue.ToString()][singer] += ticketPrice * ticketCount;  
                    }
                    else
                    {
                        venues[venue.ToString()].Add(singer, ticketPrice * ticketCount);
                    }
                    
                }
                else
                {
                    venues[venue.ToString()] = new Dictionary<string, int> {{singer, ticketPrice * ticketCount}};
                }

                line = Console.ReadLine();
            }

            foreach (var venue in venues)
            {
                Console.WriteLine(venue.Key);
                foreach (var singer in venue.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }

        }
    }
}