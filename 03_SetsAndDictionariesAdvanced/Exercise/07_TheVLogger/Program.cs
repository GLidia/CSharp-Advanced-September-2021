using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            //vlogger + followers
            Dictionary<string, List<string>> vloggers = new Dictionary<string, List<string>>();
            //vlogger + followers, following
            Dictionary<string, List<int>> count = new Dictionary<string, List<int>>();
            string input;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] command = input.Split();
                string vloggerOne = command[0];

                if (command[1] == "joined")
                {
                    if (!vloggers.ContainsKey(vloggerOne))
                    {
                        vloggers.Add(vloggerOne, new List<string>());
                        count.Add(vloggerOne, new List<int>() { 0, 0 });
                    }
                }
                else if (command[1] == "followed")
                {
                    string vloggerTwo = command[2];

                    if (vloggers.ContainsKey(vloggerOne) && vloggers.ContainsKey(vloggerTwo) && vloggerOne != vloggerTwo)
                    {

                        if (!vloggers[vloggerTwo].Contains(vloggerOne))
                        {
                            vloggers[vloggerTwo].Add(vloggerOne);
                            count[vloggerTwo][0]++;
                            count[vloggerOne][1]++;
                        }
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Keys.Count} vloggers in its logs.");
            int counter = 0;

            foreach (var vlogger in count.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Value[1]))
            {
                foreach (var name in vloggers.Where(x => x.Key == vlogger.Key))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {name.Key} : {vlogger.Value[0]} followers, {vlogger.Value[1]} following");
                    if (counter == 1)
                    {
                        foreach (var item in name.Value.OrderBy(x => x))
                        {
                            Console.WriteLine($"*  {item}");
                        }
                    }

                }

            }

        }
    }
}
