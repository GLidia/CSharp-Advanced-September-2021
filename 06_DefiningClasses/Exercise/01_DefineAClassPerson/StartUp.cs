using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.Name = "Pesho";
            personOne.Age = 20;

            Person personTwo = new Person() { Name = "Gosho", Age = 18 };

            Person personThree = new Person("Stamat", 43);

        }
    }
}
