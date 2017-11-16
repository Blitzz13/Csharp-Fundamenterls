using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            int shadowmourne = 0;
            int valanyr = 0;
            int dragonwrath = 0;
            string pattern = @"[0-9]+[ ]+\w+";

            Dictionary<string, int> goodItems = new Dictionary<string, int>();
            SortedDictionary<string, int> junkItems = new SortedDictionary<string, int>();
            goodItems.Add("shards", 0);
            goodItems.Add("fragments", 0);
            goodItems.Add("motes", 0);
            while (valanyr < 250 && shadowmourne < 250 && dragonwrath < 250)
            {
                var line = Console.ReadLine();
                var matches = Regex.Matches(line, pattern);

                for (int i = 0; i < matches.Count; i++)
                {
                    var tokens = matches[i].Value.Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
                    int quantity = int.Parse(tokens[0]);
                    string item = tokens[1].ToLower();

                    if (item == "shards" || item == "fragments" || item == "motes")
                    {

                        goodItems[item] += quantity;

                        switch (item)
                        {
                            case "shards":
                                shadowmourne += quantity;
                                break;
                            case "fragments":
                                valanyr += quantity;
                                break;
                            case "motes":
                                dragonwrath += quantity;
                                break;
                        }
                        if (shadowmourne >= 250)
                        {
                            break;
                        }
                        if (valanyr >= 250)
                        {
                            break;
                        }
                        if (dragonwrath >= 250)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (junkItems.ContainsKey(item))
                        {
                            junkItems[item] += quantity;
                        }
                        else
                        {
                            junkItems.Add(item, quantity);
                        }

                    }

                }
            }

            CheckTheWinningItem(shadowmourne, valanyr, dragonwrath, goodItems, junkItems);
        }

        private static void CheckTheWinningItem(int shadowmourne, int valanyr, int dragonwrath, Dictionary<string, int> goodItems, SortedDictionary<string, int> junkItems)
        {
            if (shadowmourne >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                goodItems["shards"] -= 250;
                ShowInventory(goodItems, junkItems);
            }
            else if (valanyr >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                goodItems["fragments"] -= 250;
                ShowInventory(goodItems, junkItems);
            }
            else if (dragonwrath >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                goodItems["motes"] -= 250;
                ShowInventory(goodItems, junkItems);
            }
        }

        private static void ShowInventory(Dictionary<string, int> inventory, SortedDictionary<string, int> junkItems)
        {
            foreach (var item in inventory.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}