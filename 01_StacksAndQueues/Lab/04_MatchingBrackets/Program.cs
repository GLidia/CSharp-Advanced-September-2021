using System;
using System.Collections.Generic;

namespace _04_MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> bracketIndexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    bracketIndexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int openingBracketIndex = bracketIndexes.Pop();
                    string expression = input.Substring(openingBracketIndex, i + 1 - openingBracketIndex);
                    Console.WriteLine(expression);
                }
            }
        }
    }
}
