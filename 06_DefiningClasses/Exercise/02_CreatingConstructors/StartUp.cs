using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person personOne = new Person();

            Console.WriteLine(personOne.Name);

            Person personTwo = new Person(19);
            Console.WriteLine(personTwo.Name + " " + personTwo.Age);

            Person personThree = new Person("Pesho", 22);
            Console.WriteLine(personThree.Name + " " + personThree.Age);
        }
    }
}
