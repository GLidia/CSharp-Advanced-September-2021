using System;
using System.Linq;
using System.Collections.Generic;

namespace _10_PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            string input;

            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] command = input.Split();

                if (command[0] == "Double")
                {
                    if (command[1] == "StartsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].StartsWith(command[2]))
                            {
                                guests.Insert(i, guests[i]);
                                i++;
                            }
                        }                         
                    }
                    else if (command[1] == "EndsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].EndsWith(command[2]))
                            {
                                guests.Insert(i, guests[i]);
                                i++;
                            }
                        }
                    }
                    else if (command[1] == "Length")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].Length == int.Parse(command[2]))
                            {
                                guests.Insert(i, guests[i]);
                                i++;
                            }
                        }
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (command[1] == "StartsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].StartsWith(command[2]))
                            {
                                guests.Remove(guests[i]);
                                i--;
                            }
                        }
                    }
                    else if (command[1] == "EndsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].EndsWith(command[2]))
                            {
                                guests.Remove(guests[i]);
                                i--;
                            }
                        }
                    }
                    else if (command[1] == "Length")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].Length == int.Parse(command[2]))
                            {
                                guests.Remove(guests[i]);
                                i--;
                            }
                        }
                    }
                }
            }

            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
        }
    }
}
