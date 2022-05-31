using System;
using System.Linq;

namespace _02_KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> appendSir = x => Console.WriteLine($"Sir {x}");
            string[] names = Console.ReadLine().Split();

            foreach (string name in names)
            {
                appendSir(name);
            }
        }
    }
}
