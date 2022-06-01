using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                people.Add(person);
            }

            foreach (Person person in people.Where(p => p.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }
        }
    }
}
