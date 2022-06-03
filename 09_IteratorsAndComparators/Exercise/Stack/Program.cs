using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Stack<string> stack = new Stack<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Push")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        string element = command[i];
                        stack.Push(element);
                    }
                }
                else if (command[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch(InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }
                }
            }

            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
