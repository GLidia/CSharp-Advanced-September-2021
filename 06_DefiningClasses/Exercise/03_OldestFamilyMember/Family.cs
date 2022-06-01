using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public List<Person> People
        {
            get { return this.people; }
            set { this.people = value; }
        }

        public Family()
        {
            this.People = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.People.Add(member);
        }

        public Person GetOldestMember()
        {
            int greatestAge = 0;
            Person oldestMember = this.People[0];

            foreach (Person member in this.People)
            {
                if (member.Age > greatestAge)
                {
                    greatestAge = member.Age;
                    oldestMember = member;
                }
            }

            return oldestMember;
        }

    }
}
