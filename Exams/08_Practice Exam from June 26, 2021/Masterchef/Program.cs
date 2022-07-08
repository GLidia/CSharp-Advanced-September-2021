using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> freshnessLevel = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            Dictionary<string, int> dishes = new Dictionary<string, int>();

            while (ingredients.Count > 0 && freshnessLevel.Count > 0)
            {
                int currentIngredient = ingredients.Peek();
                int currentFreshnessLevel = freshnessLevel.Peek();

                if (currentIngredient == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                if (currentIngredient * currentFreshnessLevel == 150)
                {
                    if (!dishes.ContainsKey("Dipping sauce"))
                    {
                        dishes.Add("Dipping sauce", 0);
                    }

                    dishes["Dipping sauce"]++;

                    ingredients.Dequeue();
                    freshnessLevel.Pop();
                }
                else if (currentIngredient * currentFreshnessLevel == 250)
                {
                    if (!dishes.ContainsKey("Green salad"))
                    {
                        dishes.Add("Green salad", 0);
                    }

                    dishes["Green salad"]++;

                    ingredients.Dequeue();
                    freshnessLevel.Pop();
                }
                else if (currentIngredient * currentFreshnessLevel == 300)
                {
                    if (!dishes.ContainsKey("Chocolate cake"))
                    {
                        dishes.Add("Chocolate cake", 0);
                    }

                    dishes["Chocolate cake"]++;

                    ingredients.Dequeue();
                    freshnessLevel.Pop();
                }
                else if (currentIngredient * currentFreshnessLevel == 400)
                {
                    if (!dishes.ContainsKey("Lobster"))
                    {
                        dishes.Add("Lobster", 0);
                    }

                    dishes["Lobster"]++;

                    ingredients.Dequeue();
                    freshnessLevel.Pop();
                }
                else
                {
                    freshnessLevel.Pop();
                    ingredients.Enqueue(ingredients.Dequeue() + 5);
                }
            }

            if (dishes.Count == 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            foreach (var item in dishes.OrderBy(x => x.Key))
            {
                Console.WriteLine($" # {item.Key} --> {item.Value}");
            }
        }
    }
}
