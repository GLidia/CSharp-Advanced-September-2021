using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Queue<long[]> stations = new Queue<long[]>();

            for (int i = 0; i < N; i++)
            {
                long[] petrolAndDistance = Console.ReadLine().Split().Select(long.Parse).ToArray();
                stations.Enqueue(petrolAndDistance);
            }

            bool isEnough = true;
            for (int i = 0; i < N; i++)
            {
                long startingPetrol = 0;

                for (int j = 0; j < N; j++)
                {
                    long[] currentStation = stations.Peek();
                    //if there's enough petrol
                    if (currentStation[0] + startingPetrol >= currentStation[1])
                    {
                        startingPetrol = currentStation[0] + startingPetrol - currentStation[1];

                    }
                    else
                    {
                        isEnough = false;                      
                    }

                    stations.Enqueue(stations.Dequeue());
                    
                }

                if (isEnough)
                {
                    Console.WriteLine(i);
                    return;
                }

                isEnough = true;
                stations.Enqueue(stations.Dequeue());
            }

        }
    }
}
