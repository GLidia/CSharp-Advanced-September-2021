using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string name = input[0];
                int age = int.Parse(input[1]);

                people.Add(name, age);
            }

            string condition = Console.ReadLine();
            int ageCondition = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<int, bool> tester = CreateTester(condition, ageCondition);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);
            PrintFilteredStudents(people, tester, printer);
        }

        private static void PrintFilteredStudents(Dictionary<string, int> people, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in people)
            {
               if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }

        private static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            if (format == "name")
            {
                return person => Console.WriteLine(person.Key);
            }
            else if (format == "age")
            {
                return person => Console.WriteLine(person.Value);
            }
            else if (format == "name age")
            {
                return person => Console.WriteLine($"{person.Key} - {person.Value}");
            }
            else
            {
                return null;
            }

        }

        private static Func<int, bool> CreateTester(string condition, int ageCondition)
        {
            if (condition == "younger")
            {
                return x => x < ageCondition;
            }
            else if (condition == "older")
            {
                return x => x >= ageCondition;
            }
            else
            {
                return null;
            }
        }
    }
}
