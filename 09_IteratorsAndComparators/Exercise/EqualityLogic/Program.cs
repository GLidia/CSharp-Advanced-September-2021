using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> people = new SortedSet<Person>();
            HashSet<Person> ppl = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                people.Add(person);
                ppl.Add(person);
            }

            Console.WriteLine(people.Count);
            Console.WriteLine(ppl.Count);
        }
    }
}
