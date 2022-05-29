using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = setSizes[0];
            int m = setSizes[1];
            HashSet<string> setN = new HashSet<string>();
            HashSet<string> setM = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string element = Console.ReadLine();
                setN.Add(element);
            }

            for (int i = 0; i < m; i++)
            {
                string element = Console.ReadLine();
                setM.Add(element);
            }

            foreach (string element in setN)
            {
                if (setM.Contains(element))
                {
                    Console.Write(element + " ");
                }
            }

        }
    }
}
