using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> filters = new List<string>();
            List<string> names = Console.ReadLine().Split().ToList();

            string input;

            while ((input = Console.ReadLine()) != "Print")
            {
                string[] command = input.Split(";");
                string action = command[0];
                string filter = command[1] + ";" + command[2];

                if (action == "Add filter")
                {
                    filters.Add(filter);
                }
                else if (action == "Remove filter")
                {
                    filters.Remove(filter);
                }
            }

            if (filters.Count == 0)
            {
                Console.WriteLine(string.Join(" ", names));
                return;
            }

            Func<string, string, bool> predicate = (x, y) => x.StartsWith(y);

            foreach (string filter in filters)
            {
                string[] instructions = filter.Split(";");
                string data = instructions[1];

                if (instructions[0] == "Starts with")
                {
                    predicate = (x, y) => x.StartsWith(y);
                }
                else if (instructions[0] == "Ends with")
                {
                    predicate = (x, y) => x.EndsWith(y);
                }
                else if (instructions[0] == "Contains")
                {
                    predicate = (x, y) => x.Contains(y);
                }
                else if (instructions[0] == "Length")
                {
                    predicate = (x, y) => x.Length.Equals(int.Parse(y));
                }

                names = Filter(names, data, predicate);
            }

            Console.WriteLine(string.Join(" ", names));
        }

        private static List<string> Filter(List<string> names, string data, Func<string, string, bool> predicate)
        {
            List<string> newList = new List<string>();

            foreach (string name in names)
            {
                if (!predicate(name, data))
                {
                    newList.Add(name);
                }
            }

            return newList;
        }
    }
}
