using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Person> people = new List<Person>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] data = input.Split();
                string name = data[0];
                int age = int.Parse(data[1]);
                string town = data[2];

                Person person = new Person(name, age, town);
                people.Add(person);
            }

            int indexOfPersonToCompareTo = int.Parse(Console.ReadLine());
            Person personToCompareTo = people[indexOfPersonToCompareTo - 1];
            int countOfMatches = 0;
            int countOfNotEqualPeople = 0;

            for (int i = 0; i < people.Count; i++)
            {
                if (i == indexOfPersonToCompareTo - 1)
                {
                    continue;
                }
                else
                {
                    int result = personToCompareTo.CompareTo(people[i]);
                    if (result == 0)
                    {
                        countOfMatches++;
                    }
                    else
                    {
                        countOfNotEqualPeople++;
                    }
                }
            }

            if (countOfMatches == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches + 1} {countOfNotEqualPeople} {people.Count}");
            }
        }
    }
}
