using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_PredicateParty_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, string, bool> predicate = (x, y) => x.StartsWith(y);
            Func<string, int, bool> otherPredicate = (x, y) => x.Length.Equals(y);
            Func<List<string>, string, Func<string, string, bool>, List<string>> remove = Remove;          
       
            string input;

            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] command = input.Split(' ');
                string action = command[0];
                string criterion = command[1];
                
                if (action == "Remove")
                {
                    if (criterion == "StartsWith")
                    {
                        string y = command[2];
                        predicate = (x, y) => x.StartsWith(y);
                        names = Remove(names, y, predicate);
                    }
                    else if (criterion == "EndsWith")
                    {
                        string y = command[2];
                        predicate = (x, y) => x.EndsWith(y);
                        names = Remove(names, y, predicate);
                    }
                    else if (criterion == "Length")
                    {
                        int y = int.Parse(command[2]);
                        names = Remove(names, y, otherPredicate);
                    }
                }
                else if (action == "Double")
                {
                    if (criterion == "StartsWith")
                    {
                        string y = command[2];
                        predicate = (x, y) => x.StartsWith(y);
                        names = Double(names, y, predicate);
                    }
                    else if (criterion == "EndsWith")
                    {
                        string y = command[2];
                        predicate = (x, y) => x.EndsWith(y);
                        names = Double(names, y, predicate);
                    }
                    else if (criterion == "Length")
                    {
                        int y = int.Parse(command[2]);
                        names = Double(names, y, otherPredicate);
                    }
                }
            }

            if (names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static List<string> Double(List<string> names, int y, Func<string, int, bool> otherPredicate)
        {
            List<string> newList = new List<string>();

            foreach (string name in names)
            {
                if (otherPredicate(name, y))
                {
                    newList.Add(name);
                    newList.Add(name);
                }
                else
                {
                    newList.Add(name);
                }
            }

            return newList;
        }

        private static List<string> Double(List<string> names, string y, Func<string, string, bool> predicate)
        {
            List<string> newList = new List<string>();

            foreach (string name in names)
            {
                if (predicate(name, y))
                {
                    newList.Add(name);
                    newList.Add(name);
                }
                else
                {
                    newList.Add(name);
                }
            }

            return newList;
        }

        private static List<string> Remove(List<string> names, int y, Func<string, int, bool> predicate)
        {
            List<string> newList = new List<string>();

            foreach (string name in names)
            {
                if (!predicate(name, y))
                {
                    newList.Add(name);
                }
            }

            return newList;
        }

        private static List<string> Remove(List<string> list, string condition, Func<string, string, bool> arg2)
        {
            List<string> newList = new List<string>();

            foreach (string name in list)
            {
                if (!arg2(name, condition))
                {
                    newList.Add(name);
                }
            }

            return newList;
        }
    }
}
