using System;
using System.Linq;

namespace _12_TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ');
            
            Func<string, int, bool> predicate = (x, y) =>
            {
                long sum = 0;
                foreach (char character in x)
                {
                    sum += character;
                }

                if (sum >= y)
                {
                    return true;
                }

                return false;
            };

            Console.WriteLine(names.Where(x => predicate(x, number)).FirstOrDefault());
        }
    }
}
