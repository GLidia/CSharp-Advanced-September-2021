using System;
using System.Linq;

namespace _07_PredicateForNamesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthToCompare = int.Parse(Console.ReadLine());
            Func<string, bool> isRightLength = x => x.Length <= lengthToCompare;
            string[] names = Console.ReadLine().Split(' ').Where(x => isRightLength(x)).ToArray();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
