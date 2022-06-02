using System;
using System.Collections.Generic;

namespace _05_GenericCountMethodStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                boxes.Add(box);
            }

            string toCompare = Console.ReadLine();
            int count = Box<string>.Compare<string>(boxes, toCompare);
            Console.WriteLine(count);
        }
    }
}
