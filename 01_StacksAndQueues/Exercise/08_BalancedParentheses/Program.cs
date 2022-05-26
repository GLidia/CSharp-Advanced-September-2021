using System;
using System.Collections.Generic;

namespace _08_BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> input = new Queue<char>(Console.ReadLine().ToCharArray());
            Stack<char> openBrackets = new Stack<char>();

            while (input.Count > 0)
            {
                char currentChar = input.Peek();

                if ((currentChar == '(' || currentChar == '{' || currentChar == '['))
                {
                    openBrackets.Push(input.Dequeue());
                }
                else if ((currentChar == '(' || currentChar == '{' || currentChar == '['))
                {
                    Console.WriteLine("NO");
                    return;
                }
                else if (currentChar == ')' || currentChar == '}' || currentChar == ']')
                {

                    if (openBrackets.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    if (currentChar == ')' && openBrackets.Peek() == '(')
                    {
                        openBrackets.Pop();
                        input.Dequeue();
                    }
                    else if (currentChar == '}' && openBrackets.Peek() == '{')
                    {
                        openBrackets.Pop();
                        input.Dequeue();
                    }
                    else if (currentChar == ']' && openBrackets.Peek() == '[')
                    {
                        openBrackets.Pop();
                        input.Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            if (openBrackets.Count > 0)
            {
                Console.WriteLine("NO");
                return;
            }

            Console.WriteLine("YES");
        }
    }
}
