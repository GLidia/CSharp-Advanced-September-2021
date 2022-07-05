using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> Ingredients;

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            Ingredients = new List<Ingredient>();
        }

        public int CurrentAlcoholLevel
        {
            get
            {
                int totalAlcohol = 0;
                foreach (Ingredient item in Ingredients)
                {
                    totalAlcohol += item.Alcohol;
                }

                return totalAlcohol;
            }
        }

        public void Add(Ingredient ingredient)
        {
            if (!Ingredients.Any(x => x.Name == ingredient.Name))
            {
                if (Ingredients.Count < Capacity)
                {
                    int totalAlcohol = CurrentAlcoholLevel;

                    if (totalAlcohol + ingredient.Alcohol <= MaxAlcoholLevel)
                    {
                        Ingredients.Add(ingredient);
                    }
                }
            }
        }

        public bool Remove(string name)
        {
            if (Ingredients.Any(x => x.Name == name))
            {
                Ingredient ingredientToRemove = Ingredients.Where(x => x.Name == name).First();
                Ingredients.Remove(ingredientToRemove);
                return true;
            }

            return false;
        }

        public Ingredient FindIngredient(string name)
        {
            return Ingredients.Where(x => x.Name == name).FirstOrDefault();
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            return Ingredients.OrderByDescending(x => x.Alcohol).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach (Ingredient item in Ingredients)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
