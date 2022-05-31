using System;
using System.Linq;

namespace _01_ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string> print = x => Console.WriteLine(x);

            foreach (string name in names)
            {
                print(name);
            }
        }
    }
}
