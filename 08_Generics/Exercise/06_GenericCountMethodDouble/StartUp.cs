using System;
using System.Collections.Generic;

namespace _06_GenericCountMethodDouble
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                Box<double> box = new Box<double>(input);
                boxes.Add(box);
            }

            double toCompare = double.Parse(Console.ReadLine());
            int count = Box<double>.Compare<double>(boxes, toCompare);
            Console.WriteLine(count);
        }
    }
}
