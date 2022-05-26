using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = rowInput; 
            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split();
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row < 0 || col < 0 || row >= jagged.Length || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (command[0] == "Add")
                {
                    jagged[row][col] += value;
                }
                else if (command[0] == "Subtract")
                {
                    jagged[row][col] -= value;
                }
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            }
        }
    }
}
