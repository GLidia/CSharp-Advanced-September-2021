using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ComparingObjects
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo([AllowNull] Person other)
        {
            if (this.Name != other.Name)
            {
                return this.Name.CompareTo(other.Name);
            }
            else if (this.Age != other.Age)
            {
                return this.Age.CompareTo(other.Age);
            }
            else
            {
                return this.Town.CompareTo(other.Town);
            }
        }
    }
}
