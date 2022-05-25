using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> sum = new Stack<string>(input.Reverse());

            while (sum.Count > 1)
            {
                double firstNum = double.Parse(sum.Pop());
                string sign = sum.Pop();
                double secondNum = double.Parse(sum.Pop());

                if (sign == "+")
                {
                    sum.Push((firstNum + secondNum).ToString());
                }
                else if (sign == "-")
                {
                    sum.Push((firstNum - secondNum).ToString());
                }
            }

            Console.WriteLine(sum.Pop());
        }
    }
}
