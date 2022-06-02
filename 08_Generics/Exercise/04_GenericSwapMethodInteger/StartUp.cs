using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_GenericSwapMethodInteger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);
                boxes.Add(box);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index1 = indexes[0];
            int index2 = indexes[1];

            Box<int>.Swap(boxes, index1, index2);

            foreach (Box<int> box in boxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}
