using System;
using System.Collections.Generic;

namespace _09_SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> versions = new Stack<string>();
            string text = String.Empty;
            versions.Push(text);
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    text += command[1];
                    versions.Push(text);
                }
                else if (command[0] == "2")
                {
                    text = text.Remove(text.Length - int.Parse(command[1]));
                    versions.Push(text);
                }
                else if (command[0] == "3")
                {
                    Console.WriteLine(text[int.Parse(command[1]) - 1]);
                }
                else if (command[0] == "4")
                {
                    versions.Pop();
                    text = versions.Peek();
                }

            }
        }
    }
}
