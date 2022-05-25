using System;
using System.Collections.Generic;

namespace _01_ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> characters = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                characters.Push(input[i]);
            }

            string result = string.Empty;
            int count = characters.Count;

            for (int i = 0; i < count; i++)
            {
                result += characters.Pop();
            }

            Console.WriteLine(result);
        }
    }
}
