using System;
using System.Collections.Generic;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            ListyIterator<string> iterator = new ListyIterator<string>();

            while((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split();

                if (command[0] == "Create")
                {
                    string[] elements = new string[command.Length - 1];

                    for (int i = 0; i < command.Length - 1; i++)
                    {
                        elements[i] = command[i + 1];
                    }

                    iterator = new ListyIterator<string>(elements);
                }
                else if (command[0] == "Move")
                {
                    Console.WriteLine(iterator.Move());
                }
                else if (command[0] == "Print")
                {
                    try
                    {
                        iterator.Print();
                    }
                    catch(ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
                else if (command[0] == "HasNext")
                {
                    Console.WriteLine(iterator.HasNext());
                }
            }
        }
    }
}
