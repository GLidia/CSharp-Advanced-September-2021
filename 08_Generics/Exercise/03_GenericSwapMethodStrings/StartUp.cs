using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_GenericSwapMethodStrings
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

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index1 = indexes[0];
            int index2 = indexes[1];

            Box<string>.Swap(boxes, index1, index2);

            foreach (Box<string> box in boxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}
