using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());
            Queue<int> plates = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> orcsLeft = new Stack<int>();

            bool platesZero = false;

            for (int i = 1; i <= numberOfWaves; i++)
            {                   
                
                if (platesZero)
                {
                    break;
                }       
                
                Stack<int> orcs = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray()); 
                


                if (i % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }

                while(orcs.Count > 0 && plates.Count > 0)
                {
                    int currentOrc = orcs.Peek();
                    int currentPlate = plates.Peek();

                    if (currentOrc > currentPlate)
                    {
                        plates.Dequeue();
                        orcs.Pop();
                        orcs.Push(currentOrc - currentPlate);
                    }
                    else if (currentOrc < currentPlate)
                    {
                        orcs.Pop();
                        int plateToAdd = currentPlate - currentOrc;
                        plates.Dequeue();
                        plates.Enqueue(plateToAdd);

                        for (int j = 0; j < plates.Count - 1; j++)
                        {
                            plates.Enqueue(plates.Dequeue());
                        }
                    }
                    else if (currentOrc == currentPlate)
                    {
                        orcs.Pop();
                        plates.Dequeue();
                    }

                    if (plates.Count == 0)
                    {
                        platesZero = true;
                        orcsLeft = orcs;
                        break;
                    }
                }
            }

            if (platesZero)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcsLeft)}");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
        }
    }
}
